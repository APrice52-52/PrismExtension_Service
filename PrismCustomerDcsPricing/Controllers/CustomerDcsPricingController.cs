using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrismCustomerDcsPricing.Models;
using PrismExtensionServices.Shared;

namespace PrismCustomerDcsPricing.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerDcsPricingController : ControllerBase
{
    
    private readonly IDbHelper _db;
    private readonly ILogger _logger;

    public CustomerDcsPricingController(IDbHelper db, ILoggerFactory loggerFactory)
    {
        _db = db;
        _logger = loggerFactory.CreateLogger("CustomerDcsPricing");
    }

    /// <summary>List all discount records for a DCS.</summary>
    [HttpGet("dcs/{dcsSid:long}")]
    public async Task<IActionResult> ListByDcs(long dcsSid)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT dcs_sid, level, discount FROM rpsods.ppitcustdcspricing WHERE dcs_sid = @dcs_sid ORDER BY level";
            cmd.Parameters.AddWithValue("@dcs_sid", dcsSid);
            return Ok(await ReadAllAsync(cmd));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error listing pricing for DCS {DcsSid}", dcsSid);
            return Problem("Unable to retrieve pricing records.");
        }
    }

    /// <summary>List all discount records for a price level.</summary>
    [HttpGet("level/{level}")]
    public async Task<IActionResult> ListByLevel(string level)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT dcs_sid, level, discount FROM rpsods.ppitcustdcspricing WHERE level = @level ORDER BY dcs_sid";
            cmd.Parameters.AddWithValue("@level", level);
            return Ok(await ReadAllAsync(cmd));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error listing pricing for level {Level}", level);
            return Problem("Unable to retrieve pricing records.");
        }
    }

    /// <summary>Get a single pricing record by its composite key.</summary>
    [HttpGet("{dcsSid:long}/{level}")]

    public async Task<IActionResult> Get(long dcsSid, string level)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT dcs_sid, level, discount FROM rpsods.ppitcustdcspricing WHERE dcs_sid = @dcs_sid AND level = @level";
            cmd.Parameters.AddWithValue("@dcs_sid", dcsSid);
            cmd.Parameters.AddWithValue("@level", level);
            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
                return Ok(ReadRow(reader));
            return NotFound();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching pricing for DCS {DcsSid}, level {Level}", dcsSid, level);
            return Problem("Unable to retrieve pricing record.");
        }
    }

    /// <summary>Create a new pricing record.</summary>
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CustomerDcsPricing record)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO rpsods.ppitcustdcspricing (dcs_sid, level, discount) VALUES (@dcs_sid, @level, @discount)";
            cmd.Parameters.AddWithValue("@dcs_sid", record.DcsSid);
            cmd.Parameters.AddWithValue("@level", record.Level);
            cmd.Parameters.AddWithValue("@discount", record.Discount);
            await cmd.ExecuteNonQueryAsync();
            return CreatedAtAction(nameof(Get), new { dcsSid = record.DcsSid, level = record.Level }, record);
        }
        catch (Exception ex) when (ex.Message.Contains("Duplicate entry"))
        {
            return Conflict("A pricing record already exists for this DCS/level combination.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error creating pricing for DCS {DcsSid}, level {Level}", record.DcsSid, record.Level);
            return Problem("Unable to create pricing record.");
        }
    }

    /// <summary>Upsert the discount for a DCS/level combination.</summary>
    [HttpPut("{dcsSid:long}/{level}")]
    public async Task<IActionResult> Upsert(long dcsSid, string level, [FromBody] decimal discount)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO rpsods.ppitcustdcspricing (dcs_sid, level, discount) VALUES (@dcs_sid, @level, @discount) ON DUPLICATE KEY UPDATE discount = @discount";
            cmd.Parameters.AddWithValue("@dcs_sid", dcsSid);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@discount", discount);
            await cmd.ExecuteNonQueryAsync();
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error upserting pricing for DCS {DcsSid}, level {Level}", dcsSid, level);
            return Problem("Unable to save pricing record.");
        }
    }

    /// <summary>Delete a pricing record.</summary>
    [HttpDelete("{dcsSid:long}/{level}")]
    public async Task<IActionResult> Delete(long dcsSid, string level)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();
            using var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM rpsods.ppitcustdcspricing WHERE dcs_sid = @dcs_sid AND level = @level";
            cmd.Parameters.AddWithValue("@dcs_sid", dcsSid);
            cmd.Parameters.AddWithValue("@level", level);
            int rows = await cmd.ExecuteNonQueryAsync();
            return rows == 0 ? NotFound() : NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error deleting pricing for DCS {DcsSid}, level {Level}", dcsSid, level);
            return Problem("Unable to delete pricing record.");
        }
    }

    /// <summary>Load all data required to render the DCS/level discount matrix.</summary>
    [HttpGet("matrix")]
    public async Task<IActionResult> GetMatrix()
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();

            var levels = new List<string>();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT DISTINCT udf5_string FROM rpsods.customer WHERE udf5_string IS NOT NULL ORDER BY udf5_string";
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                    levels.Add(reader.GetString(0));
            }

            var dcs = new List<DcsInfo>();
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT sid, dcs_code FROM rpsods.dcs WHERE active = 1 ORDER BY dcs_code";
                using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                    dcs.Add(new DcsInfo { DcsSid = reader.GetInt64(0), DcsCode = reader.GetString(1) });
            }

            List<CustomerDcsPricing> discounts;
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT dcs_sid, level, discount FROM rpsods.ppitcustdcspricing";
                discounts = await ReadAllAsync(cmd);
            }

            return Ok(new PricingMatrix { Levels = levels, Dcs = dcs, Discounts = discounts });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error loading pricing matrix");
            return Problem("Unable to load pricing matrix.");
        }
    }

    /// <summary>Replace all discount records atomically (full matrix save).</summary>
    [HttpPut("matrix")]
    public async Task<IActionResult> SaveMatrix([FromBody] List<CustomerDcsPricing> discounts)
    {
        try
        {
            using var conn = _db.GetConnection();
            await conn.OpenAsync();
            using var tx = await conn.BeginTransactionAsync();

            using (var cmd = conn.CreateCommand())
            {
                cmd.Transaction = tx;
                cmd.CommandText = "DELETE FROM rpsods.ppitcustdcspricing";
                await cmd.ExecuteNonQueryAsync();
            }

            foreach (var rec in discounts)
            {
                using var cmd = conn.CreateCommand();
                cmd.Transaction = tx;
                cmd.CommandText = "INSERT INTO rpsods.ppitcustdcspricing (dcs_sid, level, discount) VALUES (@dcs_sid, @level, @discount)";
                cmd.Parameters.AddWithValue("@dcs_sid", rec.DcsSid);
                cmd.Parameters.AddWithValue("@level", rec.Level);
                cmd.Parameters.AddWithValue("@discount", rec.Discount);
                await cmd.ExecuteNonQueryAsync();
            }

            await tx.CommitAsync();
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error saving pricing matrix ({Count} records)", discounts?.Count ?? 0);
            return Problem("Unable to save pricing matrix.");
        }
    }

    private static async Task<List<CustomerDcsPricing>> ReadAllAsync(DbCommand cmd)
    {
        var results = new List<CustomerDcsPricing>();
        using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
            results.Add(ReadRow(reader));
        return results;
    }

    private static CustomerDcsPricing ReadRow(DbDataReader reader) => new()
    {
        DcsSid   = reader.GetInt64(reader.GetOrdinal("dcs_sid")),
        Level    = reader.GetString(reader.GetOrdinal("level")),
        Discount = reader.GetDecimal(reader.GetOrdinal("discount")),
    };

    /// <summary>
    /// Given a customer and item, resolves the customer's price level (from customer.udf5_string),
    /// the item's DCS (from invn_sbs_item.dcs_sid), and returns the configured discount percentage.
    /// Returns 0 if no discount is configured for that DCS/level combination.
    /// </summary>
    [HttpGet("CustomerDiscount/{customerSid:long}/{itemSid:long}")]
    public async Task<IActionResult> GetCustomerItemDiscount(long customerSid, long itemSid) {
        try {
            using var cnn = _db.GetConnection();
            await cnn.OpenAsync();

            // 1. Read price level from customer.udf5_string
            string? level;
            using (var cmd = cnn.CreateCommand()) {
                cmd.CommandText = "SELECT udf5_string FROM rpsods.customer WHERE sid = @cust_sid";
                cmd.Parameters.AddWithValue("@cust_sid", customerSid);
                level = await cmd.ExecuteScalarAsync() as string;
            }

            if (string.IsNullOrWhiteSpace(level))
                return Ok(new { Discount = 0m });

            // 2. Read dcs_sid from invn_sbs_item
            long dcsSid;
            using (var cmd = cnn.CreateCommand()) {
                cmd.CommandText = "SELECT dcs_sid FROM rpsods.invn_sbs_item WHERE sid = @sid";
                cmd.Parameters.AddWithValue("@sid", itemSid);
                var result = await cmd.ExecuteScalarAsync();
                if (result is null or DBNull)
                    return Ok(new { Discount = 0m, Error = $"Item {itemSid} not found." });
                dcsSid = Convert.ToInt64(result);
            }

            // 3. Read discount from rpsods.ppitcustdcspricing (0 if no record exists for this DCS/level)
            decimal discount = 0m;
            using (var cmd = cnn.CreateCommand()) {
                cmd.CommandText = "SELECT discount FROM rpsods.ppitcustdcspricing WHERE dcs_sid = @dcs_sid AND level = @level";
                cmd.Parameters.AddWithValue("@dcs_sid", dcsSid);
                cmd.Parameters.AddWithValue("@level", level);
                var result = await cmd.ExecuteScalarAsync();
                if (result is not null and not DBNull)
                    discount = Convert.ToDecimal(result);
            }

            return Ok(new { Discount = discount, Level = level });
        }
        catch (Exception ex) {
            _logger.LogError(ex, "Error fetching discount for customer {CustomerSid}, item {ItemSid}", customerSid, itemSid);
            return Ok(new { Discount = 0m, Error = $"Error fetching discount for customer {customerSid}, item {itemSid}" });
        }
    }
}
