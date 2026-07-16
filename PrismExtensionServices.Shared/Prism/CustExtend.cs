using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class CustExtend
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
    public long? custsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf6string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf7string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf8string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf9string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf10string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf11string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf12string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf13string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf14string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf15string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf16string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf17string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf18string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf1largestring;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf2largestring;

}
