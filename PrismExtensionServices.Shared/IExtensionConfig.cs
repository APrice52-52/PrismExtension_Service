using System;
using System.Collections.Generic;
using System.Text;

namespace PrismExtensionServices.Shared;

public interface IExtensionConfig
{
    string Id { get; set; }     // Base-36 Plugin Id, 20 characters long, unique to this plugin.
    bool Enabled { get; set; }
    string ConfigurationData { get; set; }  // Base-64 encoded JSON string containing the configuration data for this plugin.
}

public sealed class ExtensionConfig : IExtensionConfig
{
    public string Id { get; set; } = string.Empty;
    public bool Enabled { get; set; } = false;
    public string ConfigurationData { get; set; } = string.Empty;
}