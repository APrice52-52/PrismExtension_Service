using System.Text;
using System.Text.Json;
using PrismExtensionServices.Shared;

namespace PrismExtensionServices.Plugins;

/// <summary>
/// Peeks at a plugin's raw (Base-64/JSON) configuration data to find an optional
/// "LogFileName" string property, without needing to know the plugin's strongly-typed
/// config class. Used by <c>Program.cs</c> to decide whether a plugin gets its own
/// Serilog file sink or falls back to the shared host log.
/// </summary>
internal static class PluginLogTargetResolver
{
    public static string? TryGetLogFileName(ExtensionConfig? entry)
    {
        if (entry is null || string.IsNullOrEmpty(entry.ConfigurationData))
            return null;

        try
        {
            var json = Encoding.UTF8.GetString(Convert.FromBase64String(entry.ConfigurationData));
            using var doc = JsonDocument.Parse(json);
            if (doc.RootElement.TryGetProperty("LogFileName", out var prop)
                && prop.ValueKind == JsonValueKind.String)
            {
                var name = Path.GetFileName(prop.GetString());
                return string.IsNullOrWhiteSpace(name) ? null : name;
            }
        }
        catch
        {
            // Malformed config — fall back to the shared log.
        }

        return null;
    }
}
