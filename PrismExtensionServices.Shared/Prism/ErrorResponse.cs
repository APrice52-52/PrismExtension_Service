using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class Data
{
    public object? name { get; set; }
    public object? metatype { get; set; }
    public object? comment { get; set; }
    public object? translationid { get; set; }
    public string? errors { get; set; }
    public List<object>? data { get; set; }
}

public class Headers
{
    public string? Accept { get; set; }

    [System.Text.Json.Serialization.JsonPropertyName("Auth-Session")]
    public string? AuthSession { get; set; }
}

public class Config
{
    public string? method { get; set; }
    public List<object>? transformRequest { get; set; }
    public List<object>? transformResponse { get; set; }
    public string? jsonpCallbackParam { get; set; }
    public string? url { get; set; }
    public string? data { get; set; }
    public Headers? headers { get; set; }
}

public class RestResponseRoot
{
    public Data? data { get; set; }
    public int status { get; set; }
    public Config? config { get; set; }
    public string? statusText { get; set; }
    public string? xhrStatus { get; set; }
}
