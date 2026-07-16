using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class VoucherComment
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
    public int? commentno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? comments;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? archived;
}
public class VoucherCommentPost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VoucherComment[]? data;

    public VoucherCommentPost() { }

    public VoucherCommentPost(VoucherComment comment)
    {
        data = new VoucherComment[1] { comment };
    }
}

public class VoucherCommentPostResponse
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
    public VoucherComment[]? data;
}
