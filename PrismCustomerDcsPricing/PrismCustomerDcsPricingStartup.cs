using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PrismExtensionServices.Shared;

namespace PrismCustomerDcsPricing;

internal class PrismCustomerDcsPricingStartup : IHostedService
{
    private readonly IDbHelper _db;
    private readonly ILogger _logger;

    public PrismCustomerDcsPricingStartup(IDbHelper db, ILoggerFactory loggerFactory)
    {
        _db = db;
        _logger = loggerFactory.CreateLogger("CustomerDcsPricing.Startup");
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync(cancellationToken);

            // Create table if it doesn't exist yet
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = """
                    CREATE TABLE IF NOT EXISTS rpsods.ppitcustdcspricing (
                        dcs_sid  bigint       NOT NULL DEFAULT 0,
                        level    varchar(20)  CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
                        discount decimal(8,2) NOT NULL DEFAULT 0.00,
                        PRIMARY KEY (dcs_sid, level),
                        KEY ppitidx_custprice_dcs   (dcs_sid),
                        KEY ppitidx_custprice_level  (level)
                    ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin
                    """;
                await cmd.ExecuteNonQueryAsync(cancellationToken);
            }

            // Load all active levels
            var levels = new List<string>();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT DISTINCT udf5_string FROM rpsods.customer WHERE udf5_string IS NOT NULL ORDER BY udf5_string";
                using var reader = await cmd.ExecuteReaderAsync(cancellationToken);
                while (await reader.ReadAsync(cancellationToken))
                    levels.Add(reader.GetString(0));
            }

            // Load all active DCS sids
            var dcsSids = new List<long>();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT sid FROM rpsods.dcs WHERE active = 1 ORDER BY dcs_code";
                using var reader = await cmd.ExecuteReaderAsync(cancellationToken);
                while (await reader.ReadAsync(cancellationToken))
                    dcsSids.Add(reader.GetInt64(0));
            }

            // Insert missing combinations with discount = 0, leave existing records untouched
            int inserted = 0;
            foreach (var dcsSid in dcsSids)
            {
                foreach (var level in levels)
                {
                    using var cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT IGNORE INTO rpsods.ppitcustdcspricing (dcs_sid, level, discount) VALUES (@dcs_sid, @level, 0)";
                    cmd.Parameters.AddWithValue("@dcs_sid", dcsSid);
                    cmd.Parameters.AddWithValue("@level", level);
                    inserted += await cmd.ExecuteNonQueryAsync(cancellationToken);
                }
            }

            _logger.LogInformation(
                "CustomerDcsPricing: {DcsCount} DCS × {LevelCount} levels — {Inserted} default record(s) added.",
                dcsSids.Count, levels.Count, inserted);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "CustomerDcsPricing startup check failed.");
        }
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
