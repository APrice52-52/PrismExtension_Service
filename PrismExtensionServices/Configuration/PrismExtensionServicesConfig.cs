using PrismExtensionServices.Shared;
using System.ComponentModel;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PrismExtensionServices;

[Serializable]
[SupportedOSPlatform("windows")]
public class PrismExtensionServicesConfig : IServerConfig
{
    #region Static Fields

    static PrismExtensionServicesConfig()
    {
        AppDataFolder  = Path.Combine(
                             Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                             @"Price Point IT\PrismExtensionServices");
        ConfigFolder   = AppDataFolder;
        ConfigFileName = Path.Combine(ConfigFolder, "PrismExtensionServices.json");
        LogFolder      = Path.Combine(AppDataFolder, "Logs");
    }

    [Browsable(false)]
    public static string AppDataFolder  { get; private set; }

    [Browsable(false)]
    public static string ConfigFolder   { get; private set; }

    [Browsable(false)]
    public static string ConfigFileName { get; private set; }

    [Browsable(false)]
    public static string LogFolder      { get; private set; }

    #endregion


    #region Constructor

    public PrismExtensionServicesConfig() { }

    #endregion


    #region Instance Properties

    public string DbServer { get; set; } = "localhost";
    public int    DbPort   { get; set; } = 3306;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? DbUsername { get; set; } = "";

    private string? _dbPassword = "";

    [JsonIgnore]
    public string? DbPassword { get => _dbPassword; set => _dbPassword = value; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [Browsable(false)]
    public string? DbPasswordJson
    {
        get => Encrypt(_dbPassword);
        set => _dbPassword = Decrypt(value);
    }

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


    #region Load / Save

    public static PrismExtensionServicesConfig Load() => LoadFrom(ConfigFileName);

    public static PrismExtensionServicesConfig LoadFrom(string fileName)
    {
        try
        {
            FileInfo fi = new(fileName);
            if (!Directory.Exists(fi.DirectoryName!))
                Directory.CreateDirectory(fi.DirectoryName!);
            if (!Directory.Exists(fi.DirectoryName!))
                return new PrismExtensionServicesConfig();

            PrismExtensionServicesConfig? c = null;
            try
            {
                using FileStream fs = new(fi.FullName, FileMode.Open, FileAccess.Read);
                c = JsonSerializer.Deserialize<PrismExtensionServicesConfig>(fs);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"[Config] Load failed, retrying: {ex.Message}");
                Thread.Sleep(1000);
                using FileStream fs = new(fi.FullName, FileMode.Open, FileAccess.Read);
                c = JsonSerializer.Deserialize<PrismExtensionServicesConfig>(fs);
            }

            return c ?? new PrismExtensionServicesConfig();
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"[Config] Load failed, using defaults: {ex.Message}");
            return new PrismExtensionServicesConfig();
        }
    }

    public void Save() => SaveTo(ConfigFileName);

    public void SaveTo(string fileName)
    {
        FileInfo fi = new(fileName);
        if (!Directory.Exists(fi.DirectoryName!))
            Directory.CreateDirectory(fi.DirectoryName!);

        try
        {
            using FileStream fs = new(fi.FullName, FileMode.Create, FileAccess.Write);
            JsonSerializer.Serialize<PrismExtensionServicesConfig>(fs, this);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"[Config] Save failed, retrying: {ex.Message}");
            Thread.Sleep(1000);
            try
            {
                using FileStream fs = new(fi.FullName, FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<PrismExtensionServicesConfig>(fs, this);
            }
            catch (Exception ex2)
            {
                Console.Error.WriteLine($"[Config] Save retry failed: {ex2.Message}");
                throw;
            }
        }
    }

    #endregion


    #region Encryption / Decryption

    private static readonly byte[] _entropy = new byte[] { 7, 42, 183, 61, 200 };

    private string? Encrypt(string? clearText)
    {
        if (string.IsNullOrEmpty(clearText))
            return null;

        return Convert.ToBase64String(
            ProtectedData.Protect(
                Encoding.UTF8.GetBytes(clearText),
                _entropy,
                DataProtectionScope.LocalMachine));
    }

    private string? Decrypt(string? encryptedText)
    {
        if (string.IsNullOrEmpty(encryptedText))
            return null;

        try {
            var bytes = Convert.FromBase64String(encryptedText);
            var decryptedBytes = ProtectedData.Unprotect(bytes, _entropy, DataProtectionScope.LocalMachine);
            return Encoding.UTF8.GetString(decryptedBytes);
        }
        catch (Exception) {
            return encryptedText; // Return the original text if decryption fails
        }
    }

    #endregion
}
