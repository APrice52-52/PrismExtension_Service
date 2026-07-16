using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
internal class ResponseMessage<T>
{
    public string? name { get; set; }
    public string? metatype { get; set; }
    public string? comment { get; set; }
    public string? translationid { get; set; }
    public string? errors { get; set; }
    [System.Text.Json.Serialization.JsonIgnore]
    public ResponseError[]? errorObj
    {
        get
        {
            try
            {
                return JsonSerializer.Deserialize<ResponseError[]>(errors!);
            }
            catch
            {
                return new ResponseError[0];
            }
        }
    }

    public T[]? data { get; set; }
}

internal class InventoryResponseMessage
{
    public string? name { get; set; }
    public string? metatype { get; set; }
    public string? comment { get; set; }
    public string? translationid { get; set; }
    public string? errors { get; set; }
    [System.Text.Json.Serialization.JsonIgnore]
    public ResponseError[]? errorObj {
        get
        {
            try {
                return JsonSerializer.Deserialize<ResponseError[]>(errors ?? "");
            }
            catch {
                return new ResponseError[0];
            }
        }
    }

    public InventoryAddResponseData[]? data { get; set; }
}

#pragma warning disable 0649, 0414
internal class InventoryAddResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InventoryItem[]? inventoryitems;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InventoryAddResponseData[]? data;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? newstylesid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public AdjSid[]? adjustmentsids;
}

public class InventoryAddResponseData
{
    public InventoryItem[]? inventoryitems;
}

internal class ResponseError
{
    public DateTime? date { get; set; }
    [System.Text.Json.Serialization.JsonPropertyName("class")]
    public string? errorClass { get; set; }
    public string? errorcode { get; set; }
    public string? errormsg { get; set; }
    public int? httpcode { get; set; }
    public string? httpmessage { get; set; }
    public string? functionname { get; set; }
    public string? paramvalues { get; set; }
}


