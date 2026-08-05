using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class Session
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? token;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? username;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? employeesid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? employeename;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(BoolConverter))]
    public bool? employeeissysadmin;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(BoolConverter))]
    public bool? employeeactive;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? controllersid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? workstation;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? workstationid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(JsonStringToNumberConverter))]
    public string? workstationnumber;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? subsidiarysid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(JsonStringToNumberConverter))]
    public string? subsidiarynumber;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? storesid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? storenumber;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storecode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public LicenseInfo? licenseinfo;
}
