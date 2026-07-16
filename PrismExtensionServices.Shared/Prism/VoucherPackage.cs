using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class VoucherPackage
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? createdby;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? createddatetime;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? modifiedby;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? modifieddatetime;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? controllersid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? originapplication;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? postdate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? rowversion;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tenantsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? vousid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? pkgno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? received;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? asnno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? vouclass;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? vouheld;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? voustatus;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? vouactive;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sbssid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? voutotalpackages;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? voutotalpackagesreceived;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendcode;
}
