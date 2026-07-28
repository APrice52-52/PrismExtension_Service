namespace PrismCustomerDcsPricing.Models;

public class CustomerDcsPricing
{
    public long DcsSid { get; set; }
    public string Level { get; set; } = string.Empty;
    public decimal Discount { get; set; }
}
