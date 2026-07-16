using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class LicenseInfo
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? productcode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? productversion;
}
