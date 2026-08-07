using System.Reflection;
using PpitConfig;
using PrismExtensionServices.Shared;

namespace PrismExtensionServices.Plugins;

internal sealed record PluginDescriptor(Assembly Assembly, IPrismPlugin Plugin);

internal static class PluginLoader
{
    /// <summary>
    /// Scans <paramref name="pluginsFolder"/> for per-plugin subdirectories (each the
    /// <c>dotnet publish</c> output of one plugin project), loads every DLL in each
    /// subdirectory in its own <see cref="PluginLoadContext"/>, and returns descriptors
    /// for every DLL that contains a concrete <see cref="IPrismPlugin"/> implementation.
    /// Each plugin gets its own subdirectory so that private dependency DLLs (which may
    /// differ in version between plugins) never collide on disk.
    /// </summary>
    public static IReadOnlyList<PluginDescriptor> LoadAll(string pluginsFolder, ILogger logger)
    {
        var results = new List<PluginDescriptor>();

        if (!Directory.Exists(pluginsFolder))
        {
            logger.LogWarning("Plugins folder not found: {Folder}", pluginsFolder);
            return results;
        }

        foreach (var pluginDir in Directory.GetDirectories(pluginsFolder))
            results.AddRange(LoadFromDirectory(pluginDir, logger));

        return results;
    }

    private static IEnumerable<PluginDescriptor> LoadFromDirectory(string pluginDir, ILogger logger)
    {
        var results = new List<PluginDescriptor>();

        if (IsDisabledViaIniFile(pluginDir, logger))
        {
            logger.LogInformation("Plugin folder '{Folder}' disabled via plugin.ini — skipping", pluginDir);
            return results;
        }

        foreach (var dll in Directory.GetFiles(pluginDir, "*.dll", SearchOption.TopDirectoryOnly))
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

    /// <summary>
    /// Checks for a <c>plugin.ini</c> file directly inside <paramref name="pluginDir"/>
    /// containing a line like <c>enabled=false</c>. Used as a config-independent escape
    /// hatch to exclude a plugin folder from scanning entirely (e.g. for a broken plugin,
    /// before its Id/config entry is even known). Absence of the file, or any parse
    /// failure, is treated as "enabled" (fail open).
    /// </summary>
    private static bool IsDisabledViaIniFile(string pluginDir, ILogger logger)
    {
        var iniPath = Path.Combine(pluginDir, "plugin.ini");
        if (!File.Exists(iniPath))
            return false;

        try
        {
            foreach (var rawLine in File.ReadAllLines(iniPath))
            {
                var line = rawLine.Trim();
                if (line.Length == 0 || line.StartsWith(';') || line.StartsWith('#'))
                    continue;

                var parts = line.Split('=', 2);
                if (parts.Length != 2)
                    continue;

                if (!parts[0].Trim().Equals("enabled", StringComparison.OrdinalIgnoreCase))
                    continue;

                var value = parts[1].Trim();
                return value.Equals("false", StringComparison.OrdinalIgnoreCase)
                    || value.Equals("0", StringComparison.Ordinal)
                    || value.Equals("no", StringComparison.OrdinalIgnoreCase);
            }
        }
        catch (Exception ex)
        {
            logger.LogWarning(ex, "Failed to read plugin.ini in {Folder} — treating plugin as enabled", pluginDir);
        }

        return false;
    }
}
