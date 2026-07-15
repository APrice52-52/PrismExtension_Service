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

        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}
