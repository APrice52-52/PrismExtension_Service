using Microsoft.Extensions.DependencyInjection;
using PrismExtensionServices.Shared;

namespace SoCancelFeePlugin;

public class SoCancelFeePlugin : IPrismPlugin
{
    public string Id => "SOCANCELFEE00PLUGIN1";
    public string Name => "SO Cancel Fee Plugin";

    public void ConfigureServices(IServiceCollection services) { }
}
