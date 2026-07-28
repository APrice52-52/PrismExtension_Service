using Microsoft.Extensions.DependencyInjection;
using PrismExtensionServices.Shared;

namespace PrismCustomerDcsPricing;

public class PrismCustomerDcsPricingPlugin : IPrismPlugin
{
    public string Id => "CUSTDCSPRICING000001";
    public string Name => "Customer DCS Pricing Plugin";

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHostedService<PrismCustomerDcsPricingStartup>();
    }
}
