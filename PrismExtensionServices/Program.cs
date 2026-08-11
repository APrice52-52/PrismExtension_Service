using Microsoft.AspNetCore.HttpOverrides;
using PrismExtensionServices.Plugins;
using PrismExtensionServices.Services;
using PrismExtensionServices.Shared;
using Serilog;
using Microsoft.Extensions.FileProviders;

namespace PrismExtensionServices;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // ── Windows Service ───────────────────────────────────────────────────
        builder.Host.UseWindowsService(options =>
        {
            options.ServiceName = "Prism Extension Service";
        });

        // ── Configuration ─────────────────────────────────────────────────────
        var config = PrismExtensionServicesConfig.Load();
        Console.WriteLine($"DB User: '{config.DbReadUsername}'");
        Console.WriteLine($"DB Password empty: {string.IsNullOrEmpty(config.DbReadPassword)}");

        // ── Logging ───────────────────────────────────────────────────────────
        Directory.CreateDirectory(config.LogFolder);

        // Resolve plugins folder: treat a non-rooted path as relative to the exe.
        if (!Path.IsPathRooted(config.PluginsFolder))
            config.PluginsFolder = Path.Combine(AppContext.BaseDirectory, config.PluginsFolder);

        // Load plugins first (using a bootstrap console-only logger) so we know which
        // plugins want their own log file before building the final Log.Logger.
        using var bootstrapLoggerFactory = LoggerFactory.Create(b => b.AddConsole());
        var bootstrapLogger = bootstrapLoggerFactory.CreateLogger<Program>();
        var plugins = PluginLoader.LoadAll(config.PluginsFolder, bootstrapLogger)
            .Where(p =>
            {
                if (!config.Plugins.TryGetValue(p.Plugin.Id, out var ext))
                {
                    bootstrapLogger.LogInformation(
                        "Plugin '{Name}' (id={Id}) has no configuration entry — skipping", p.Plugin.Name, p.Plugin.Id);
                    return false;
                }

                if (!ext.Enabled)
                {
                    bootstrapLogger.LogInformation(
                        "Plugin '{Name}' (id={Id}) is disabled — skipping", p.Plugin.Name, p.Plugin.Id);
                    return false;
                }

                return true;
            })
            .ToList();

        foreach (var plugin in plugins)
        {
            Console.WriteLine($"PLUGIN: {plugin.Plugin.Name}");
            Console.WriteLine($"ASSEMBLY: {plugin.Assembly.FullName}");
        }

        var pluginLogTargets = plugins
            .Select(p => new
            {
                AssemblyName = p.Assembly.GetName().Name,
                LogFileName = PluginLogTargetResolver.TryGetLogFileName(
                    config.Plugins.GetValueOrDefault(p.Plugin.Id))
            })
            .Where(t => t.AssemblyName is not null && t.LogFileName is not null)
            .ToList();

        var loggerConfig = new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft.AspNetCore", Serilog.Events.LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .WriteTo.Console();

        loggerConfig.WriteTo.Logger(lc => lc
            .Filter.ByExcluding(evt => pluginLogTargets.Any(t => Serilog.Filters.Matching.FromSource(t.AssemblyName!)(evt)))
            .WriteTo.File(
                path: Path.Combine(config.LogFolder, "PrismExtensionServices-.log"),
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 90));

        foreach (var target in pluginLogTargets)
        {
            loggerConfig.WriteTo.Logger(lc => lc
                .Filter.ByIncludingOnly(Serilog.Filters.Matching.FromSource(target.AssemblyName!))
                .WriteTo.File(
                    path: Path.Combine(config.LogFolder, $"{target.LogFileName}-.log"),
                    rollingInterval: RollingInterval.Day,
                    retainedFileCountLimit: 90));
        }

        Log.Logger = loggerConfig.CreateLogger();

        builder.Host.UseSerilog();

        // ── Kestrel port ──────────────────────────────────────────────────────
        builder.WebHost.UseUrls($"http://127.0.0.1:{config.ServicePort}");

        // ── Reverse proxy ─────────────────────────────────────────────────────
        // Always deployed behind Apache at base-path /ppExtApi.
        // Trust all forwarded headers from the local proxy.
        builder.Services.Configure<ForwardedHeadersOptions>(options =>
        {
            options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
            options.KnownIPNetworks.Clear();
            options.KnownProxies.Clear();
        });

        // ── CORS ──────────────────────────────────────────────────────────────
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(policy =>
                policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        });

        // ── Core services ─────────────────────────────────────────────────────
        builder.Services.AddSingleton(config);
        builder.Services.AddSingleton<IDbHelper, DbHelper>();
        builder.Services.AddSingleton<IPrismHelper, PrismHelper>();
        builder.Services.AddSingleton<IPrismPluginHost, PrismPluginHost>();

        // ── Plugin registration ──────────────────────────────────────────────
        var mvcBuilder = builder.Services.AddControllers();

        var razorBuilder = builder.Services
            .AddRazorPages();

        foreach (var (assembly, plugin) in plugins)
        {
            Console.WriteLine($"Registering plugin: {plugin.Name}");

            mvcBuilder.AddApplicationPart(assembly);
            razorBuilder.AddApplicationPart(assembly);

            plugin.ConfigureServices(builder.Services);
        }

        //foreach (var (assembly, plugin) in plugins)
        //{
        //    mvcBuilder.AddApplicationPart(assembly);
        //    //Cyclecount
        //    razorBuilder.AddApplicationPart(assembly);

        //    plugin.ConfigureServices(builder.Services);
        //}


        // ── OpenAPI ───────────────────────────────────────────────────────────
        builder.Services.AddOpenApi();

        // ─────────────────────────────────────────────────────────────────────
        var app = builder.Build();



        app.UseForwardedHeaders();

        app.UsePathBase("/ppExtApi");

        var cycleCountWwwroot = Path.Combine(
            AppContext.BaseDirectory,
            "plugins",
            "cyclecount",
            "wwwroot"
        );

        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(cycleCountWwwroot),
            RequestPath = "/cyclecount"
        });
        if (app.Environment.IsDevelopment())
            app.MapOpenApi();

        // Some proxy servers (e.g. local site proxies) compress+base64-encode the query string
        // into a single "qryenc" parameter (zlib deflate, then base64). Decompress it here so
        // the rest of the pipeline sees the original query parameters.
        app.Use(async (context, next) =>
        {
            if (context.Request.Query.TryGetValue("qryenc", out var encoded))
            {
                try
                {
                    var bytes = Convert.FromBase64String(encoded!);
                    using var compressed = new MemoryStream(bytes);
                    using var zlib = new System.IO.Compression.ZLibStream(compressed, System.IO.Compression.CompressionMode.Decompress);
                    using var decompressed = new MemoryStream();
                    await zlib.CopyToAsync(decompressed);
                    var qs = System.Text.Encoding.UTF8.GetString(decompressed.ToArray());
                    context.Request.QueryString = new QueryString("?" + qs);
                }
                catch
                {
                    // Leave the request as-is if decompression fails.
                }
            }
            await next();
        });

        app.UseCors();

        //Cyclecount
        app.Use(async (context, next) =>
        {
            context.Response.Headers.Remove("X-Frame-Options");
            context.Response.Headers["Content-Security-Policy"] = "frame-ancestors *";
            await next();
        });

        app.UseAuthorization();

        app.MapControllers();

        app.MapRazorPages();

        var endpoints = app.Services
            .GetRequiredService<EndpointDataSource>()
            .Endpoints;

        foreach (var endpoint in endpoints)
        {
            Console.WriteLine($"ENDPOINT FOUND: {endpoint.DisplayName}");
        }

        app.Run();
    }
}
