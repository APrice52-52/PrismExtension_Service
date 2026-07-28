using PrismExtensionServices.Shared;
using System.Text;
using System.Text.Json;

namespace PrismExtensionServices.Services;

internal sealed class PrismPluginHost : IPrismPluginHost
{
    private readonly PrismExtensionServicesConfig _config;

    public int Version => 0;

    public IServerConfig ServerConfig => _config;

    public PrismPluginHost(PrismExtensionServicesConfig config) {
        _config = config;
    }

    public T? GetConfiguration<T>(string pluginId) where T : class {
        if (_config.Plugins.TryGetValue(pluginId, out ExtensionConfig? entry))
        {
            var json = Encoding.UTF8.GetString(Convert.FromBase64String(entry.ConfigurationData));
            return JsonSerializer.Deserialize<T>(json)
                ?? throw new InvalidOperationException("Failed to deserialize plugin configuration");
        }
        return null;
    }
}
