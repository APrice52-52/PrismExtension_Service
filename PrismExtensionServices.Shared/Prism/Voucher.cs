using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class Voucher
{
    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public string? KeyValue { get; set; }

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
    public string? controllersid;
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
    public long? sbssid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? storesid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? vouno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? voutype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? vouclass;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? vendsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? payeesid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendacctno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? vendorinvoicesid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? clerksid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? station;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? workstation;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? origstoresid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstation;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? status;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? procstatus;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? pono;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? tono;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? pkgno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? shipmentno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? costhandlingcode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? updatepriceflag;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? usevat;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? discperc;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? discamt;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? taxpercincl;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? taxamtincl;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? taxpercexcl;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? taxamtexcl;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? arriveddate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custfld;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? seasonsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? refvousid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? audited;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? cms;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? verified;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? purchclearamt;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? cmspostdate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? reviewbysid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? reviewdate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? reviewnote;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? approvbysid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? approvdate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? wsseqno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? held;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? active;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? rate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? carrierid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? controller;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? origcontroller;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? createdbysid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? modifiedbysid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? alextractdate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? alpostdate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? docrefno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? slipflag;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? approvnotes;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? approvstatus;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? pendingoverride;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? trackingno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? transreasonid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? voureasonsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? contractdate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? asnno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? archived;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? taxareasid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? taxarea2sid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? resolvstatus;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? resolvsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? note;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? noofpkgs;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? posid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tosid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? asnsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? refdocsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? vousubtotal;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? voutotal;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? disctype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? taxincltype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? taxexcltype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? brmarked;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? publishstatus;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? reversedflag;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? slipsbssid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? slipstoresid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? lineitems;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? totalqty;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? doctotalcost;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? totalpackages;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? totalpackagesreceived;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? voucherqtydiff;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? itemcostdiff;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lineitemsdiff;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? serialdiff;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lotdiff;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<VoucherItem>? recvitem;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<VoucherFee>? recvfee;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<VoucherTerm>? recvterm;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<VoucherComment>? recvcomment;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<VoucherApproval>? recvapproval;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<VoucherPackage>? recvpackage;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxarea;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxarea2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendoraddress1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendoraddress2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendoraddress3;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendoraddress4;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendoraddress5;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendoraddress6;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorcity;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorstate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorpostalcode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorpostalcodeextension;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendoraddress;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstoreaddress;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? origstoreno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origaddress1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origaddress2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origaddress3;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origaddress4;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origaddress5;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstorename;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstoreudf1string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstoreudf2string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstoreudf3string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstoreudf4string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstoreudf5string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origzip;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? orderdate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? canceldate;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendcode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? vendid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? payeecode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? sbsno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? storeno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? clerkname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? modifiedbyemplid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? modifiedbyemplname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? createdbyemplname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? approvedbyemplname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? vendinvcid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendinvcno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? vendinvcdate;
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
    public string? storename;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? zip;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorudf1string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorudf2string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorudf3string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorudf4string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorudf5string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? vendorudf6string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? vendorudf1date;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? vendorudf2date;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storeudf1string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storeudf2string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storeudf3string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storeudf4string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storeudf5string;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? reasonname;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? reasontype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origintimezone;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? seasoncode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? clerkorigsbsno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? approvedbyorigsbsno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? createdbyorigsbsno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? modifiedbyorigsbsno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? slipsbsno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? slipstoreno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? slipsid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? slipno;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? slipreversedflag;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storecode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstorecode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? slipstorecode;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storephone1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstorephone1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? slipstorephone1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storephone2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origstorephone2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? slipstorephone2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? pcflag;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? apflag;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? glflag;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custom0;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custom1;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custom2;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custom3;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custom4;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custom5;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custom6;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custom7;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custom8;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custom9;


    [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
    public List<VoucherItem> VoucherItems { get; set; } = new();


    public Voucher ToCreateNew()
    {
        return new Voucher()
        {
            address1 = address1,
            address2 = address2,
            address3 = address3,
            address4 = address4,
            address5 = address5,
            arriveddate = arriveddate,
            audited = audited,
            custom0 = custom0,
            custom1 = custom1,
            custom2 = custom2,
            custom3 = custom3,
            custom4 = custom4,
            custom5 = custom5,
            custom6 = custom6,
            custom7 = custom7,
            custom8 = custom8,
            custom9 = custom9,
            discamt = discamt,
            discperc = discperc,
            disctype = disctype,
            held = held,
            note = note,
            orderdate = orderdate,
            pkgno = pkgno,
            postdate = postdate,
            sbsno = sbsno,
            sbssid = sbssid,
            seasoncode = seasoncode,
            seasonsid = seasonsid,
            shipmentno = shipmentno,
            storecode = storecode,
            storeno = storeno,
            storesid = storesid,
            taxarea = taxarea,
            trackingno = trackingno,
            vendcode = vendcode,
            vendsid = vendsid,
            vouclass = vouclass,
            voutype = voutype
        };
    }
}


public class VoucherPost
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Voucher[]? data;
}

public class VoucherPostResponse
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? name;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? metatype;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? comment;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? translationid;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? errors;
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Voucher[]? data;
}
