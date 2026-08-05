using PpitConfig;
using PrismExtensionServices.Shared;
using System.Runtime.Versioning;
using System.Text.Json.Serialization;

namespace PrismExtensionServices;

[Serializable]
[SupportedOSPlatform("windows")]
public class PrismExtensionServicesConfig : ConfigBase
{
    #region Constructor

    public PrismExtensionServicesConfig() { }

    #endregion


    #region Identity

    public override string ApplicationName => "PrismExtensionServices";

    #endregion


    #region Instance Properties

    public string DbServer { get; set; } = "localhost";
    public int    DbPort   { get; set; } = 3306;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DbReadUsername { get; set; } = "";

    [JsonConverter(typeof(EncryptedStringConverter))]
    public string? DbReadPassword { get; set; } = "";

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DbManagementUsername { get; set; } = "";

    [JsonConverter(typeof(EncryptedStringConverter))]
    public string? DbManagementPassword { get; set; } = "";

    public int  ServicePort      { get; set; } = 5000;
    public int  LogExpiryDays    { get; set; } = 30;
    public bool LogDebugMessages { get; set; } = false;

    /// <summary>
    /// Path to the plugins folder. Non-rooted paths are resolved relative to
    /// <see cref="System.AppContext.BaseDirectory"/> by the host at startup.
    /// </summary>
    public string PluginsFolder { get; set; } = "plugins";

    /// <summary>
    /// Per-plugin configuration keyed by the plugin's 20-character Base-36 Id.
    /// Each value is an arbitrary JSON object — the plugin deserialises it.
    /// </summary>
    public Dictionary<string, ExtensionConfig> Plugins { get; set; } = new();

    #endregion


    #region Load

    public static PrismExtensionServicesConfig Load()
    {
        try { return LoadInstance<PrismExtensionServicesConfig>(); }
        catch { return new PrismExtensionServicesConfig(); }
    }

    #endregion
}
