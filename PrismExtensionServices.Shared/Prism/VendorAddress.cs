using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class VendorAddress
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
    public string? originapplication = Constants.OriginApplication;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? postdate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? rowversion;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tenantsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? vendsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? primaryflag;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? active;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? companyname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? address1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? address2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? address3;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? address4;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? address5;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? address6;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? city;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? state;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? postalcode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? postalcodeextension;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? countrysid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? seqno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? addresstypesid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? countrycode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? addresstypename;
}
