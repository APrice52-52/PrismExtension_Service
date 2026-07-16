using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism
{

    public class VendorPut
    {
        public Vendor[]? data;

    }

    public class Vendor
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? sid;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? createdby;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? createddatetime = DateTime.Now;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? modifiedby;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? modifieddatetime = DateTime.Now;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? controllersid;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? originapplication  = Constants.OriginApplication;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? postdate;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? rowversion  = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? tenantsid;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? vendcode;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? active;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? vendname;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? info1;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? info2;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? termtype;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? accountno;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? tradediscperc;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? vendleadtime;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? apflag  = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? currencysid;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? regional  = false;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? countrysid;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? qbid;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? udf1string;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? udf2string;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? udf3string;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? udf4string;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? udf5string;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? udf6string;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? udf1date;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? udf2date;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? notes;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? image;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? vendid;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? sbssid;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? languagesid;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? publishstatus  = 0;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? mincost;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? minqty;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? vendorterm;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public VendorAddress[]? vendoraddress = new VendorAddress[0];
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public VendorContact[]? vendorcontact = new VendorContact[0];
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? primarycontactfirstname;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? primarycontactlastname;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? primarycontactphone1;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? primarycontactphone2;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? primarycontactemail;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? sbsno;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? countrycode;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? currencycode;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? languagename;
    
    }
}
