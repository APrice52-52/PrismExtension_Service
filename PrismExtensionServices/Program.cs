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
        // Replace the default appsettings.json with the shared ProgramData config.
        builder.Configuration.Sources.Clear();
        builder.Configuration
            .AddJsonFile(PrismExtensionServicesConfig.FilePath, optional: false, reloadOnChange: false)
            .AddEnvironmentVariables("PRISM_")
            .AddCommandLine(args);

        var config = builder.Configuration.Get<PrismExtensionServicesConfig>()
                     ?? new PrismExtensionServicesConfig();

        // Resolve plugins folder: treat a non-rooted path as relative to the exe.
        if (!Path.IsPathRooted(config.PluginsFolder))
            config.PluginsFolder = Path.Combine(AppContext.BaseDirectory, config.PluginsFolder);

        // ── Kestrel port ──────────────────────────────────────────────────────
        builder.WebHost.UseUrls($"http://+:{config.ServicePort}");

        // ── Core services ─────────────────────────────────────────────────────
        builder.Services.AddSingleton(config);
        builder.Services.AddSingleton<IDbHelper, DbHelper>();
        builder.Services.AddSingleton<IPrismHelper, PrismHelper>();
        builder.Services.AddSingleton<IPrismPluginHost, PrismPluginHost>();

        // ── Plugin loading ────────────────────────────────────────────────────
        // Build a temporary logger so we can report plugin load results early.
        using var loggerFactory = LoggerFactory.Create(b => b.AddConsole());
        var startupLogger = loggerFactory.CreateLogger<Program>();

        var plugins = PluginLoader.LoadAll(config.PluginsFolder, startupLogger);

        var mvcBuilder = builder.Services.AddControllers();

        foreach (var (assembly, plugin) in plugins)
        {
            mvcBuilder.AddApplicationPart(assembly);   // discovers controllers in the plugin
            plugin.ConfigureServices(builder.Services); // plugin-level DI registrations
        }

        // ── OpenAPI ───────────────────────────────────────────────────────────
        builder.Services.AddOpenApi();

        // ─────────────────────────────────────────────────────────────────────
        var app = builder.Build();

        if (app.Environment.IsDevelopment())
            app.MapOpenApi();

        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}
