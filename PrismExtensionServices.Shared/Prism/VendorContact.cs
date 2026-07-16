using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism
{
    public class VendorContact
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
        public string? firstname;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? lastname;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? titlesid;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? contacttypesid;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? primaryflag;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? emailtypesid;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? emailaddress;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? phone1typesid;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? phone1no;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? phone2typesid;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? phone2no;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? active;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? seqno;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? title;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? phonetype1;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? phonetype2;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? emailtype;

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? titleid;

    }
}
