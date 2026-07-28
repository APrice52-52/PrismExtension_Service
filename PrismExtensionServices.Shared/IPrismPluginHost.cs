namespace PrismExtensionServices.Shared;

public interface IPrismPluginHost
{
    int Version { get; }

    public IServerConfig ServerConfig { get; }

    public T? GetConfiguration<T>(string pluginId) where T : class;
}
