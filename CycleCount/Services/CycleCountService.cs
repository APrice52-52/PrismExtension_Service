using CycleCount.Configuration;
using CycleCount.Models;
using MySqlConnector;
using Microsoft.Extensions.Logging;
using PrismExtensionServices.Shared;

namespace CycleCount.Services
{
    public class CycleCountService
    {
        private readonly IDbHelper _db;
        private readonly CycleCountConfig _config;
        private readonly ILogger<CycleCountService> _logger;

        public CycleCountService(IDbHelper db, CycleCountConfig config, ILogger<CycleCountService> logger)
        {
            _db = db;
            _config = config;
            _logger = logger;
        }

        public async Task<List<CycleCountItem>> GetRandomItems(long storeSid)
        {
            List<CycleCountItem> items = new();

            using var conn = _db.GetConnection();

            await conn.OpenAsync();

            string sql = @"
            SELECT
                i.sid,
                i.alu,
                i.description1,
                i.description2,
                i.attribute,
                i.item_size,
                q.qty,
                q.store_sid
            FROM invn_sbs_item i
            INNER JOIN invn_sbs_item_qty q
                ON i.sid = q.invn_sbs_item_sid
            WHERE 
                q.store_sid = @storeSid
                and q.qty > 0
            ORDER BY RAND()
            LIMIT 10";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@storeSid", storeSid);

            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                items.Add(new CycleCountItem
                {
                    ItemSid = reader.GetInt64("sid"),
                    StoreSid = reader.GetInt64("store_sid"),

                    ALU = reader["alu"]?.ToString() ?? "",

                    Description1 = reader["description1"]?.ToString() ?? "",

                    Description2 = reader["description2"]?.ToString() ?? "",

                    Attribute = reader["attribute"]?.ToString() ?? "",

                    Size = reader["item_size"]?.ToString() ?? "",

                    SystemQty = reader.GetDecimal("qty"),

                    CountedQty = 0
                });
            }

            return items;
        }

        //public async Task SaveCycleCount(List<CycleCountItem> items)
        public async Task<bool> SaveCycleCount(List<CycleCountItem> items)
        {

            try {
                if (items.Count == 0)
                    return false;

                if (items.Select(i => i.StoreSid).Distinct().Count() > 1)
                    throw new InvalidOperationException("All items must belong to the same store.");

                using var conn = _db.GetConnection();
                await conn.OpenAsync();

                using (var trn = await conn.BeginTransactionAsync()) {

                    try {

                        // Check if we have one already & quit if so:
                        using (var cmd = conn.CreateCommand()) {
                            cmd.Transaction = trn;
                            cmd.CommandText = @$"
                                                SELECT 
                                                    EXISTS(
                                                            SELECT 1 FROM rpsods.cyclecounts 
                                                            WHERE 
                                                                store_sid = {items.First().StoreSid} 
                                                                and count_date = CURRENT_DATE()
                                                    ) as count_exists
                                                ";
                            var result = await cmd.ExecuteScalarAsync();
                            if (result != null && result != DBNull.Value && Convert.ToInt32(result) == 1)
                                return false;
                        }



                        // Save the counts:
                        using (var cmd = conn.CreateCommand()) {
                            cmd.CommandText = @"
                                                INSERT INTO cyclecounts
                                                (
                                                    item_sid,
                                                    store_sid,
                                                    alu,
                                                    counted_qty,
                                                    system_qty,
                                                    count_date
                                                )
                                                VALUES
                                                (
                                                    @item_sid,
                                                    @store_sid,
                                                    @alu,
                                                    @counted_qty,
                                                    @system_qty,
                                                    @count_date
                                                )
                                    ";
                            cmd.Parameters.Add("@item_sid", MySqlDbType.Int64);
                            cmd.Parameters.Add("@store_sid", MySqlDbType.Int64);
                            cmd.Parameters.Add("@alu", MySqlDbType.VarChar, 50);
                            cmd.Parameters.Add("@counted_qty", MySqlDbType.Decimal, 18);
                            cmd.Parameters.Add("@system_qty", MySqlDbType.Decimal, 18);
                            cmd.Parameters.Add("@count_date", MySqlDbType.Date);
                            cmd.Transaction = trn;

                            await cmd.PrepareAsync();
                            foreach (var item in items) {

                                cmd.Parameters["@item_sid"].Value = item.ItemSid;
                                cmd.Parameters["@store_sid"].Value = item.StoreSid;
                                cmd.Parameters["@alu"].Value = item.ALU;
                                cmd.Parameters["@counted_qty"].Value = item.CountedQty;
                                cmd.Parameters["@system_qty"].Value = item.SystemQty;
                                cmd.Parameters["@count_date"].Value = DateTime.Today;

                                _ = await cmd.ExecuteNonQueryAsync();
                                //var rows = await cmd.ExecuteNonQueryAsync();
                            }
                        }

                        await trn.CommitAsync();
                        return true;

                    }
                    catch (Exception ex) {
                        //Utilities.LogError("SaveCycleCount()", ex);
                        _logger.LogError(ex, "SaveCycleCount()");
                        await trn.RollbackAsync();
                        return false;
                    }
                }
            }
            catch (Exception ex) {
                //Utilities.LogError("SaveCycleCount()", ex);
                _logger.LogError(ex, "SaveCycleCount()");
                return false;
            }
        }

        public async Task<bool> HasCountBeenCompletedToday(long storeSid)
        {
            if (_config.ExemptStores.Contains(storeSid))
                return true;

            try {
                using var conn = _db.GetConnection();

                await conn.OpenAsync();

                string sql = @"
                SELECT COUNT(*)
                FROM cyclecounts
                WHERE store_sid = @StoreSid
                AND count_date = CURDATE()
            ";

                using var cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@StoreSid", storeSid);

                var result = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                return result > 0;
            }
            catch (Exception ex) {
                //Utilities.LogError($"HasCountBeenCompletedToday({storeSid})", ex);
                _logger.LogError(ex, "HasCountBeenCompletedToday({StoreSid})", storeSid);
                return false;
            }
        }
    }
}
