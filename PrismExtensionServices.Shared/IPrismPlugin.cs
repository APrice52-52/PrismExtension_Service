using Microsoft.Extensions.DependencyInjection;

namespace PrismExtensionServices.Shared;

public interface IPrismPlugin
{
    /// <summary>20-character Base-36 unique identifier for this plugin.</summary>
    string Id { get; }

    string Name { get; }

    void ConfigureServices(IServiceCollection services);
}
