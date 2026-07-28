using Microsoft.AspNetCore.HttpOverrides;
using PrismExtensionServices.Plugins;
using PrismExtensionServices.Services;
using PrismExtensionServices.Shared;

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

        // Resolve plugins folder: treat a non-rooted path as relative to the exe.
        if (!Path.IsPathRooted(config.PluginsFolder))
            config.PluginsFolder = Path.Combine(AppContext.BaseDirectory, config.PluginsFolder);

        // ── Kestrel port ──────────────────────────────────────────────────────
        builder.WebHost.UseUrls($"http://+:{config.ServicePort}");

        // ── Reverse proxy ─────────────────────────────────────────────────────
        // Always deployed behind Apache at base-path /ppExtApi.
        // Trust all forwarded headers from the local proxy.
        builder.Services.Configure<ForwardedHeadersOptions>(options =>
        {
            options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
            options.KnownIPNetworks.Clear();
            options.KnownProxies.Clear();
        });

        // ── Core services ─────────────────────────────────────────────────────
        builder.Services.AddSingleton(config);
        builder.Services.AddSingleton<IDbHelper, DbHelper>();
        builder.Services.AddSingleton<IPrismHelper, PrismHelper>();
        builder.Services.AddSingleton<IPrismPluginHost, PrismPluginHost>();

        // ── Plugin loading ────────────────────────────────────────────────────
        using var loggerFactory = LoggerFactory.Create(b => b.AddConsole());
        var startupLogger = loggerFactory.CreateLogger<Program>();

        var plugins = PluginLoader.LoadAll(config.PluginsFolder, startupLogger);

        var mvcBuilder = builder.Services.AddControllers();

        foreach (var (assembly, plugin) in plugins)
        {
            mvcBuilder.AddApplicationPart(assembly);
            plugin.ConfigureServices(builder.Services);
        }

        // ── OpenAPI ───────────────────────────────────────────────────────────
        builder.Services.AddOpenApi();

        // ─────────────────────────────────────────────────────────────────────
        var app = builder.Build();

        app.UseForwardedHeaders();
        app.UsePathBase("/ppExtApi");

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

        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}
