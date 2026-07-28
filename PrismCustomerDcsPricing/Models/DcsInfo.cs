using System.Text.Json.Serialization;

namespace PrismCustomerDcsPricing.Models;

public class DcsInfo
{
    [JsonNumberHandling(JsonNumberHandling.WriteAsString | JsonNumberHandling.AllowReadingFromString)]
    public long DcsSid { get; set; }
    public string DcsCode { get; set; } = string.Empty;
}
