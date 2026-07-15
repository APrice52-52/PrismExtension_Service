using System.Text.Json;

namespace PrismExtensionServices.Shared;

public class PrismExtensionServicesConfig
{
    public static readonly string FilePath =
        @"C:\ProgramData\Price Point IT\PrismExtensionServices\PrismExtensionServices.json";

    // Database
    public string DbServer { get; set; } = "localhost";
    public int DbPort { get; set; } = 3306;
    public string DbUsername { get; set; } = "";

    /// <summary>DPAPI-encrypted password, stored as Base-64.</summary>
    public string DbPasswordJson { get; set; } = "";

    // Service
    public int ServicePort { get; set; } = 5000;

    // Logging
    public int LogExpiryDays { get; set; } = 30;
    public bool LogDebugMessages { get; set; } = false;

    // Plugins folder (absolute path or relative to the executable)
    public string PluginsFolder { get; set; } = "plugins";

    /// <summary>
    /// Per-plugin configuration keyed by the plugin's 20-character Base-36 Id.
    /// Each value is an arbitrary JSON object — the plugin is responsible for deserialising it.
    /// </summary>
    public Dictionary<string, JsonElement> Plugins { get; set; } = new();
}
