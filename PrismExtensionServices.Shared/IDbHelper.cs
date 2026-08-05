using MySqlConnector;

namespace PrismExtensionServices.Shared;

public interface IDbHelper
{
    MySqlConnection GetConnection();
    // OracleConnection GetConnection();
    MySqlConnection GetManagementConnection();
}
