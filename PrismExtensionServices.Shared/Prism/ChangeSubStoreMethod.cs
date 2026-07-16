using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class ChangeSubStoreMethod
{
    public ChangeSubStoreMethod() { }

    public ChangeSubStoreMethod(long sbsSid, long storeSid)
    {
        Params.SubsidiarySid = sbsSid;
        Params.StoreSid = storeSid;
    }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MethodName = "ChangeSubStoreMethod";
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ChangeSubStoreMethodParams? Params = new ChangeSubStoreMethodParams();
}

public class ChangeSubStoreMethodParams
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? SubsidiarySid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? StoreSid;
}

public class ChangeSubStoreResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? MethodName = "ChangeSubStoreMethod";
    public string? comments;
    public bool? introspection = false;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public ChangeSubStoreResponseParams? Params;
}
public class ChangeSubStoreResponseParams
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? result;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? error;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? token;
}

