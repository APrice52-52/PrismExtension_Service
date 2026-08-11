//using System.ComponentModel;
//using System.Text;
//using System.Text.Json;
//using System.Text.Json.Serialization;

//namespace CycleCount.Configuration;

//public class CycleCountConfig
//{

//    [Browsable(false)]
//    public static string RetryFolder { get; private set; }

//    [Browsable(false)]
//    public static string AppDataFolder { get; private set; }

//    [Browsable(false)]
//    public static string ConfigFileName { get; private set; }

//    [Browsable(false)]
//    public static string ConfigFolder { get; private set; }

//    [Browsable(false)]
//    public static string LogFolder { get; private set; }

//    public string DbServer { get; set; } = "localhost";
//    public int DbPort { get; set; } = 3306;

//    public string? DbUsername { get; set; } = "reportuser";

//    private string? _dbPassword = "report";

//    public long DefaultStoreSid { get; set; } = 719839606000135005;
//    public int ServicePort { get; set; } = 5103;
//    public List<long> ExemptStores { get; set; } = [];

//    [JsonIgnore]
//    public string? DbPassword { get => _dbPassword; set => _dbPassword = value; }

//    public string? DbPasswordJson
//    {
//        get {
//            return Encrypt(_dbPassword);
//        }
//        set {
//            _dbPassword = Decrypt(value);
//        }
//    }

//    public int LogExpiryDays { get; set; } = 400;

//    static CycleCountConfig() {
//        AppDataFolder = Path.Combine(
//                    Environment.GetFolderPath(
//                                    Environment.SpecialFolder.CommonApplicationData
//                                    ),
//                    "Price Point IT\\PrismCycleCount"
//                    );
//        ConfigFolder = AppDataFolder;
//        ConfigFileName = Path.Combine(ConfigFolder, "CycleCountConfig.json");
//        LogFolder = Path.Combine(AppDataFolder, "Logs");
//        RetryFolder = Path.Combine(AppDataFolder, "Retry");
//    }

//    private static readonly byte[] _entropy = new byte[] { 11, 65, 99, 26, 237 };

//    private string? Encrypt(string? clearText) {
//        if (string.IsNullOrEmpty(clearText))
//            return null;

//        return Convert.ToBase64String(
//            System.Security.Cryptography.ProtectedData.Protect(
//                                    Encoding.UTF8.GetBytes(clearText),
//                                    _entropy,
//                                    System.Security.Cryptography.DataProtectionScope.LocalMachine
//                                    )
//            );
//    }

//    private string? Decrypt(string? encryptedText) {
//        if (string.IsNullOrEmpty(encryptedText))
//            return null;

//        var bytes = Convert.FromBase64String(encryptedText);
//        var decryptedBytes = System.Security.Cryptography.ProtectedData.Unprotect(
//                                                                                bytes,
//                                                                                _entropy,
//                                                                                System.Security.Cryptography.DataProtectionScope.LocalMachine
//                                                                                );
//        return Encoding.UTF8.GetString(decryptedBytes);
//    }

//    public static CycleCountConfig Load() {
//        return LoadFrom(ConfigFileName);
//    }

//    public static CycleCountConfig LoadFrom(string fileName) {
//        try {
//            CycleCountConfig? c = null;
//            FileInfo fi = new FileInfo(fileName);
//            if (!Directory.Exists(fi.DirectoryName!))
//                Directory.CreateDirectory(fi.DirectoryName!);
//            if (!Directory.Exists(fi.DirectoryName!))
//                return new CycleCountConfig();


//            try {
//                using (FileStream fs = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read)) {
//                    c = JsonSerializer.Deserialize<CycleCountConfig>(fs);
//                }
//            }
//            catch (Exception ex) {
//                //Utilities.LogEvent(ex);
//                System.Threading.Thread.Sleep(1000); // Wait a bit in case something is reading the file.
//                using (FileStream fs = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read)) {
//                    c = JsonSerializer.Deserialize<CycleCountConfig>(fs);
//                }
//            }

//            return c ?? new CycleCountConfig();

//        }
//        catch (Exception ex) {
//            //Utilities.LogEvent(ex);
//            return new CycleCountConfig();
//        }
//    }

//    public void Save() {
//        SaveTo(ConfigFileName);
//    }

//    public void SaveTo(string fileName) {

//        FileInfo fi = new FileInfo(fileName);
//        if (!Directory.Exists(fi.DirectoryName!))
//            Directory.CreateDirectory(fi.DirectoryName!);
//        try {
//            using (FileStream fs = new FileStream(fi.FullName, FileMode.Create, FileAccess.Write)) {
//                JsonSerializer.Serialize<CycleCountConfig>(fs, this);
//            }
//        }
//        catch (Exception ex) {
//            //Utilities.LogEvent(ex);
//            System.Threading.Thread.Sleep(1000); // Wait a bit in case something is reading the file.
//            try {
//                using (FileStream fs = new FileStream(fi.FullName, FileMode.Create, FileAccess.Write)) {
//                    JsonSerializer.Serialize<CycleCountConfig>(fs, this);
//                }
//            }
//            catch (Exception ex2) {
//                //Utilities.LogEvent(ex2);
//                throw;
//            }
//        }
//    }



//}

namespace CycleCount.Configuration;

public class CycleCountConfig
{
    public long DefaultStoreSid { get; set; } = 719839606000135005;
    public List<long> ExemptStores { get; set; } = [];
}