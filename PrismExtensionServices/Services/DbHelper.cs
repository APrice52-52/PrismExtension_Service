using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using MySqlConnector;
using PrismExtensionServices.Shared;

namespace PrismExtensionServices.Services;

[SupportedOSPlatform("windows")]
internal sealed class DbHelper : IDbHelper
{
    private readonly PrismExtensionServicesConfig _config;

    public DbHelper(PrismExtensionServicesConfig config)
    {
        _config = config;
    }

    public MySqlConnection GetConnection()
    {
        var cs = new MySqlConnectionStringBuilder
        {
            Server   = _config.DbServer,
            Port     = (uint)_config.DbPort,
            UserID   = _config.DbUsername,
            Password = DecryptPassword(_config.DbPasswordJson),
        };
        return new MySqlConnection(cs.ConnectionString);
    }

    /// <summary>
    /// Decrypts a DPAPI-protected password stored as Base-64
    /// (same format used by StyleViewConfig.DbPasswordJson).
    /// </summary>
    private static string DecryptPassword(string base64)
    {
        if (string.IsNullOrEmpty(base64))
            return string.Empty;

        var cipherBytes = Convert.FromBase64String(base64);
        var plainBytes  = ProtectedData.Unprotect(cipherBytes, null, DataProtectionScope.LocalMachine);
        return Encoding.UTF8.GetString(plainBytes);
    }
}
