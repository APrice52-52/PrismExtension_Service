using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism
{

    public class DcsPut
    {
        public Dcs[]? data;
    }

    public class Dcs
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? sid = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? createdby = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? createddatetime = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? modifiedby = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? modifieddatetime = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? controllersid = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? originapplication = Constants.OriginApplication;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime? postdate = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? rowversion = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? tenantsid = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? dcscode = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? sbssid = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? useqtydecimals = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? taxcodesid = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public short? margintype = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? active = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public long? marginvalue = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? patternsid = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? dname = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? cname = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? sname = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? dlongname = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? clongname = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? slongname = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonConverter(typeof(SidConverter))]
        public long? tagcodesid = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? regional = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public byte[]? image = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public short? publishstatus = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? d = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? c = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? s = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? marginpctg = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? markuppctg = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public decimal? coefficient = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? taxcode = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? sbsno = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? patternname = null;
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? taxname = null;
    }
}
