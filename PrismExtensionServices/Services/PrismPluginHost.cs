using PrismExtensionServices.Shared;
using System.Text.Json;

namespace PrismExtensionServices.Services;

internal sealed class PrismPluginHost : IPrismPluginHost
{
    private readonly PrismExtensionServicesConfig _config;

    public int Version => 0;


    public PrismPluginHost(PrismExtensionServicesConfig config) {
        _config = config;
    }

    public T? GetConfiguration<T>(string pluginId) where T : class {
        if (_config.Plugins.ContainsKey(pluginId))
        {
            return JsonSerializer.Deserialize<T>(
                _config.Plugins[pluginId].ConfigurationData) 
                ?? 
                throw new InvalidOperationException("Failed to deserialize plugin configuration");
        } else {
            return null;
        }
    }
}
