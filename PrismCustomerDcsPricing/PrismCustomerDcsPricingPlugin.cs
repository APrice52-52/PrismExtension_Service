using Microsoft.Extensions.DependencyInjection;
using PrismExtensionServices.Shared;

namespace PrismCustomerDcsPricing;

public class PrismCustomerDcsPricingPlugin : IPrismPlugin
{
    public string Id => "4J0G-5TBT-TX5T-Z0SO";
    public string Name => "Customer DCS Pricing Plugin";

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHostedService<PrismCustomerDcsPricingStartup>();
    }
}
