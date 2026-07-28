using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PrismExtensionServices.Shared;

public interface IServerConfig
{
    string DbServer { get; set; }
    int DbPort { get; set; }
    string? DbUsername { get; set; }
    string? DbPassword { get; set; }
}
