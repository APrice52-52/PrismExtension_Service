using MySqlConnector;
using PrismExtensionServices.Shared;

namespace PrismExtensionServices.Services;

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
            Database = "rpsods",
            Server   = _config.DbServer,
            Port     = (uint)_config.DbPort,
            UserID   = _config.DbReadUsername,
            Password = _config.DbReadPassword
        };
        return new MySqlConnection(cs.ConnectionString);
    }

    public MySqlConnection GetManagementConnection() {
        var cs = new MySqlConnectionStringBuilder {
            Server = _config.DbServer,
            Port = (uint)_config.DbPort,
            UserID = _config.DbManagementUsername,
            Password = _config.DbManagementPassword
        };
        return new MySqlConnection(cs.ConnectionString);
    }

    public async Task<MySqlConnection> GetOpenConnectionAsync() {
        var connection = GetConnection();
        await connection.OpenAsync();
        return connection;
    }
}
