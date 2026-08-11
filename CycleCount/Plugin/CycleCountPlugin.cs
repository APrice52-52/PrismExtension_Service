using Microsoft.Extensions.DependencyInjection;
using PrismExtensionServices.Shared;
using CycleCount.Configuration;
using CycleCount.Services;

namespace CycleCount;

public class CycleCountPlugin : IPrismPlugin
{
    public string Id => "CYCLCOUNT001XXXXXXX";
    public string Name => "Cycle Count";

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton(sp =>
            sp.GetRequiredService<IPrismPluginHost>().GetConfiguration<CycleCountConfig>(Id));
        services.AddSingleton<CycleCountService>();
    }
}