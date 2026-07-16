using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
#pragma warning disable 0649, 0414

internal class AdjSid
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? adjsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? adjno;
}
