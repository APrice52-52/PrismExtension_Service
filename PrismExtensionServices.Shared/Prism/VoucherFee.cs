using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class VoucherFee
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
    public decimal? amt;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? purchfeetypesid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? feetype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? feename;
}

public class VoucherFeePost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VoucherFee[]? data;

    public VoucherFeePost() { }

    public VoucherFeePost(VoucherFee fee)
    {
        data = new VoucherFee[1] { fee };    
    }

}

public class VoucherFeePostResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? name;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? metatype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? comment;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? translationid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? errors;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VoucherFee[]? data;
}
