using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class VoucherItem
{

    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public string? ItemLookup;

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
    public string? originapplication = "RProPrismWeb";
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
    public int? itempos;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? itemsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? qty;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? origqty;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? price;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cost;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? fccost;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? currencysid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? taxcodesid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? taxperc;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? taxarea2sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? taxcode2sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? taxperc2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? taxamtexcl;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? taxamtincl;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? shippingamt;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? discamt;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? cartonno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? cartonstatus;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custfld;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? scanupc;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? serialno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? lotnumber;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udfvalue1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udfvalue2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udfvalue3;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udfvalue4;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? origcost;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemnote1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemnote2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemnote3;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemnote4;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemnote5;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemnote6;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemnote7;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemnote8;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemnote9;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemnote10;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? spreadfeeamt;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? altupc;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? altalu;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? altcost;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? altvendcode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? archived;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? fromasn;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? sublocid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? snqty;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? snactive;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? snreceived;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? snsold;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? sntransferred;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? snsoreserved;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? snreturned;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? snreturnedtovnd;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? snadjusted;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? invnsbsvendorsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxarea2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxcode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxcode2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? extcost;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? extprice;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? discpctg;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? lastsolddate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? storeohqty;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? lotexipydate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udfvalue5;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udfvalue6;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udfvalue7;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udfvalue8;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? description1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? description2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? description3;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? description4;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? attr;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? size;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? upc;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? vendsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? lastrcvddate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? currencyalphacode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? itemuid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendcode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? dcscode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? useqtydecimals;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? serialtype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? lottype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? kittype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? alu;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? dname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? cname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? sname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? ohcheckapproved;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? pricewtax;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? extpricewtax;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? pricewotax;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? extpricewotax;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxname2;
}

public class VoucherItemPost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VoucherItem[] data = new VoucherItem[1];
}

