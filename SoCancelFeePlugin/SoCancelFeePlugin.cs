using Microsoft.Extensions.DependencyInjection;
using PrismExtensionServices.Shared;

namespace SoCancelFeePlugin;

public class SoCancelFeePlugin : IPrismPlugin
{
    public string Id => "4J3I-ZIYP-FE5T-Z1TE";
    public string Name => "SO Cancel Fee Plugin";

    public void ConfigureServices(IServiceCollection services) { }
}
