using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrismExtensionServices.Shared;

namespace SoCancelFeePlugin.Controllers;

[ApiController]
[Route("[controller]")]
public class SoCancelFeesController : ControllerBase
{
    private readonly IDbHelper _db;
    private readonly IPrismPluginHost _pluginHost;
    private readonly ILogger<SoCancelFeesController> _logger;

    public SoCancelFeesController(IDbHelper db, IPrismPluginHost pluginHost, ILogger<SoCancelFeesController> logger)
    {
        _db = db;
        _pluginHost = pluginHost;
        _logger = logger;
    }



    [HttpGet("getorderbalance")]
    public async Task<IActionResult> GetSoBalance([FromQuery] long soSid) {
        try {

            OrderBalance? result = await GetSoBalanceInternal(soSid);

            if (result != null) {
                return Ok(result);
            } else { 
                return NotFound($"No order balance found for SoSid: {soSid}"); 
            }
        }
        catch (Exception ex) {
            _logger.LogError(ex, "An error occurred while fetching the order balance for SoSid: {SoSid}", soSid);
            return Problem($"Unable to read SO information for SoSid: {soSid}.");
        }
    }


    [HttpPost("cancelorder")]
    public async Task<IActionResult> CancelSo([FromQuery] long soSid, [FromBody] CancellationMessage message)
    {
        throw new NotImplementedException();
    }




    private async Task<OrderBalance?> GetSoBalanceInternal(long soSid) {
        try {

            using var connection = _db.GetConnection();
            await connection.OpenAsync();

            using var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM OrderBalances WHERE SoSid = @SoSid";
            command.Parameters.AddWithValue("@SoSid", soSid);

            using var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync()) {
                return new OrderBalance {
                    SoSid = reader.GetInt64(reader.GetOrdinal("SoSid")),
                    Balance = reader.GetDecimal(reader.GetOrdinal("Balance")),
                    FeePercentage = reader.GetDecimal(reader.GetOrdinal("FeePercentage")),
                    FeeAmount = reader.GetDecimal(reader.GetOrdinal("FeeAmount")),
                    FeeOnTotal = reader.GetBoolean(reader.GetOrdinal("FeeOnTotal"))
                };
            } else {
                throw new InvalidOperationException($"No order balance found for SoSid: {soSid}");
            }
        }
        catch (Exception ex) {
            _logger.LogError(ex, "An error occurred while fetching the order balance for SoSid: {SoSid}", soSid);
            return null;
        }
    }
}
