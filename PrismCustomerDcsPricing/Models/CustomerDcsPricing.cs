using System.Text.Json.Serialization;

namespace PrismCustomerDcsPricing.Models;

public class CustomerDcsPricing
{
    [JsonNumberHandling(JsonNumberHandling.WriteAsString | JsonNumberHandling.AllowReadingFromString)]
    public long DcsSid { get; set; }
    public string Level { get; set; } = string.Empty;
    public decimal Discount { get; set; }
}
