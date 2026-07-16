using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class VoucherApproval
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
    public int? approvlevel;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? approvbyid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? approvdate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? approvnotes;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? approvstatus;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? archived;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? approvbysid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? approvedbyemplname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? approvedbyorigsbsno;
}
