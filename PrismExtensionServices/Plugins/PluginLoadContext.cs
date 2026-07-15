using System.Reflection;
using System.Runtime.Loader;

namespace PrismExtensionServices.Plugins;

/// <summary>
/// Isolated AssemblyLoadContext for a single plugin DLL.
/// The shared assembly (PrismExtensionServices.Shared) is intentionally
/// resolved from the default context so that interface types are identical
/// across the host and all plugins.
/// </summary>
internal sealed class PluginLoadContext : AssemblyLoadContext
{
    private readonly AssemblyDependencyResolver _resolver;

    public PluginLoadContext(string pluginPath)
        : base(name: Path.GetFileNameWithoutExtension(pluginPath), isCollectible: false)
    {
        _resolver = new AssemblyDependencyResolver(pluginPath);
    }

    protected override Assembly? Load(AssemblyName assemblyName)
    {
        // Shared assembly must resolve from the default context so that
        // IPrismPlugin (and all other shared types) are the same Type object.
        if (assemblyName.Name is "PrismExtensionServices.Shared")
            return null;

        var path = _resolver.ResolveAssemblyToPath(assemblyName);
        return path is not null ? LoadFromAssemblyPath(path) : null;
    }
}
