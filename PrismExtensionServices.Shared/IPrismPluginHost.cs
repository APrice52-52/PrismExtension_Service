namespace PrismExtensionServices.Shared;

public interface IPrismPluginHost
{
    int Version { get; }

    public T? GetConfiguration<T>(string pluginId) where T : class;
}
