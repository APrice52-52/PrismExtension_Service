using System.Reflection;
using PpitConfig;
using PrismExtensionServices.Shared;

namespace PrismExtensionServices.Plugins;

internal sealed record PluginDescriptor(Assembly Assembly, IPrismPlugin Plugin);

internal static class PluginLoader
{
    /// <summary>
    /// Scans <paramref name="pluginsFolder"/> for DLLs, loads each in its own
    /// <see cref="PluginLoadContext"/>, and returns descriptors for every DLL
    /// that contains a concrete <see cref="IPrismPlugin"/> implementation.
    /// </summary>
    public static IReadOnlyList<PluginDescriptor> LoadAll(string pluginsFolder, ILogger logger)
    {
        var results = new List<PluginDescriptor>();

        if (!Directory.Exists(pluginsFolder))
        {
            logger.LogWarning("Plugins folder not found: {Folder}", pluginsFolder);
            return results;
        }

        foreach (var dll in Directory.GetFiles(pluginsFolder, "*.dll", SearchOption.TopDirectoryOnly))
        {
            var ctx = new PluginLoadContext(dll);

            Assembly asm;
            try
            {
                asm = ctx.LoadFromAssemblyPath(dll);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to load plugin assembly: {Dll}", dll);
                continue;
            }

            var pluginType = asm.GetTypes().FirstOrDefault(
                t => typeof(IPrismPlugin).IsAssignableFrom(t) && t.IsClass && !t.IsAbstract);

            if (pluginType is null)
            {
                logger.LogDebug("No IPrismPlugin implementation found in {Dll} — skipping", dll);
                continue;
            }

            IPrismPlugin plugin;
            try
            {
                plugin = (IPrismPlugin)Activator.CreateInstance(pluginType)!;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Failed to instantiate {Type} in {Dll}", pluginType.FullName, dll);
                continue;
            }

            logger.LogInformation("Loaded plugin '{Name}' (id={Id}) from {Dll}", plugin.Name, plugin.Id, Path.GetFileName(dll));
            results.Add(new PluginDescriptor(asm, plugin));

            // Publish the plugin DLL to PpitConfig's central ConfigTypes folder so
            // PpitConfigurationManager can resolve this plugin's ConfigBase-derived config type
            // when editing its ConfigurationData blob (see ConfigTypeResolver).
            try
            {
                Directory.CreateDirectory(ConfigTypeResolver.CentralConfigTypesFolder);
                var dest = Path.Combine(ConfigTypeResolver.CentralConfigTypesFolder, Path.GetFileName(dll));
                File.Copy(dll, dest, overwrite: true);
            }
            catch (Exception ex)
            {
                logger.LogWarning(ex, "Failed to publish plugin DLL to central ConfigTypes folder: {Dll}", dll);
            }
        }

        return results;
    }
}
