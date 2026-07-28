namespace PrismCustomerDcsPricing.Models;

public class PricingMatrix
{
    public List<string> Levels { get; set; } = [];
    public List<DcsInfo> Dcs { get; set; } = [];
    public List<CustomerDcsPricing> Discounts { get; set; } = [];
}
