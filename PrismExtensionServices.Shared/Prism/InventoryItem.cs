using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;


public class InventoryPut
{
    public InventoryDatum[]? data;
}

public class InventoryDatum
{
    public string? OriginApplication;
    public PrimaryItemDefinition? PrimaryItemDefinition;
    public InventoryItem[]? InventoryItems;
    public bool UpdateStyleDefinition = false;
    public bool UpdateStyleCost = false;
    public bool UpdateStylePrice = false;
    [JsonConverter(typeof(SidConverter))]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public long? DefaultReasonSidForQtyMemo = null;
    [JsonConverter(typeof(SidConverter))]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public long? DefaultReasonSidForCostMemo = null;
    [JsonConverter(typeof(SidConverter))]
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public long? DefaultReasonSidForPriceMemo = null;
}

public class PrimaryItemDefinition
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? dcssid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? vendsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string? description1 = null;
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string? description2 = null;
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string? attribute = null;
    [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
    public string? itemsize = null;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sid;
}

public class InventoryItem
{

    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public ImagePost[]? Images { get; set; } = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? imagepath;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sid = null;

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
    public long? controllersid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? originapplication = Constants.OriginApplication;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? postdate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? rowversion;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tenantsid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? invnitemuid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sbssid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? alu;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? stylesid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? dcssid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? vendsid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? description1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? description2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? description3;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? description4;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? longdescription;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? text1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? text2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? text3;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? text4;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? text5;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? text6;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? text7;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? text8;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? text9;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? text10;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? attribute;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? spif;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? currencysid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? lastsolddate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? markdowndate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? discontinueddate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? taxcodesid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? udf1float;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? udf2float;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? udf3float;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? udf1date;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? udf2date;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? udf3date;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemsize;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? fccost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? fstprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? firstrcvddate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? lastrcvddate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lastrcvdcost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? commsid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? discschedulesid = null;

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
    public DateTime? sellabledate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? orderabledate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? orderable;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? useqtydecimals;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? description;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? regional;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? active;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? qtypercase;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? upc;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? maxdiscperc1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? maxdiscperc2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? itemno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? serialtype;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? lottype;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? kittype;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? scalesid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? promoqtydiscweight;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? promoinvenexclude;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? noninventory;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? noncommitted;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? itemstate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? publishstatus;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? ltypriceinpoints;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? ltypointsearned;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? minordqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? vendorlistcost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? tradediscpercent;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? forceorigtax;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InvnQuantity[]? invnquantity;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InvnPrice[]? invnprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InvnMedia[]? invnmedia;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InvnVendor[]? invnvendor;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InvnKit[]? invnkit;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InvnLty[]? invnlty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public InvnExtend[]? invnextend;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxcode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? activestoresid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? activepricelevelsid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? activeseasonsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrdbprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrpricewt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrohqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrcaseqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrsoldqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrrcvdqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstronorderedqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstravailqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrextcost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrextprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrextpricewt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrtaxpctg;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrtaxamt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrtaxpctg2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrtaxamt2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrexttaxamt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrexttaxamt1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrexttaxamt2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrmarginpctg;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrmarginamt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrextmarginamt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrmarginamtwt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrextmarginamtwt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrmarkuppctg;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrcoefficient;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrminqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrmaxqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrminextcost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrminextprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrminextpricewt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrmaxextcost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrmaxextprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrmaxextpricewt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrohqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrextcost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrextprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrminqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrminextcost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrminextprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrminextpricewt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrmaxqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrmaxextcost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrmaxextprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? cmpstrmaxextpricewt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf12string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf8string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf13string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf9string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf10string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf11string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf2largestring;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf14string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf15string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf1largestring;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf6string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf7string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? dcscode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? sbsno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? sbsname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? scaleno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? scalename;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorcode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? vendorid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? currencyalphacode;

    //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    //public string? imagepath;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? cname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? dname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? sname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? docitemsid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? docitemrowversion;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? height;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? length;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? width;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? specialorder;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? docqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? doccaseqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? docprice;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? doccost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? itemimage;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? itemimageindex;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? actstrqtysid = null;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? actstrqtyrowver;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrnewminqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? actstrnewmaxqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? actstrmmbegindate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? actstrmmenddate;


}

public class ImagePost
{
    public ImageData[]? data;
}

public class ImageData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? image;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? imageindex;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? imagepath;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? resource;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public string? originalFileName;
}
public class InvnExtend
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
    public long? invnsbsitemsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf6string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf7string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf8string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf9string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf10string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf11string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf12string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf13string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf14string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf15string;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf1largestring;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf2largestring;
}

public class InvnKit
{
}

public class InvnLty
{
}

public class InvnMedia
{
}

public class InvnPrice
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
    public long? invnitemuid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sbssid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? seasonsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? pricelvlsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? price;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? qtyrequired;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? invnsbsitemsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? sbsno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? pricelvl;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? seasoncode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? pricelvlname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? seasonname;

}



public class InvnQuantity
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
    public long? sbssid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? storesid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? qty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? minqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? maxqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? newminqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? newmaxqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? transferinqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? transferoutqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? minmaxbegindate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? minmaxenddate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? soldqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? rcvdqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? onorderedqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? toinorderedqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? toinsentqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? tooutorderedqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? tooutsentqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? poorderedqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? porcvdqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? soorderedqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? sosentqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? asnintransitqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? lastonhandqtydate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? invnsbsitemsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? autoconfigsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SerialInfo[]? serialinfo;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public LotInfo[]? lotinfo;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? availableqty;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? sbsno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? sbsname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storename;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? storeno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storecode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? defaultsubloc1id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? defaultsubloc2id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? defaultsubloc3id;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public SublocQtyInfo[]? sublocqtyinfo;
}

public class SerialInfo
{
}

public class PutInvnQueryData
{
    public InvnQueryData[]? data;
}

public class InvnQueryData
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? activestoresid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? activepricelevelsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? activeseasonsid;
}


public class LotInfo
{
}

public class SublocQtyInfo
{
}

public class InvnVendor
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
    public long? invnitemuid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? sbssid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? vendsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? upc;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? alu;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? scaleno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? vendno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lastrcvdcost;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? invnsbsitemsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? sbsno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorcode;
}




//public class InventoryPut
//{
//    public InventoryItem[]? data;
//}

//public class InventoryItem
//{
//    public long ItemSid { get; set; }
//    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
//    public string? Alu { get; set; }
//    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
//    public long? Upc { get; set; }
//    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
//    public string? Description1 { get; set; }
//    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
//    public string? Description2 { get; set; }
//    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
//    public string? Description3 { get; set; }
//    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
//    public string? Description4 { get; set; }
//    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
//    public string? Attribute { get; set; }
//    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
//    public string? Size { get; set; }
//    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
//    public long? DcsSid { get; set; }
//}
