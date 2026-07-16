using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
 public class CustomerAddress
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
    public long? custsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? primaryflag;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? active;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? addressname;

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
    public DateTime? begindate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? enddate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? seasonalbegindate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? seasonalenddate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? addresstypesid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? addresscode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? billship;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? phonesid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? altphonesid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? addressallowcontact;


    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? taxareasid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? taxarea2sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? addressline1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? seqno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxarea;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxarea2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? addresstype;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? countrycode;

}
