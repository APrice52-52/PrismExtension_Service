using PrismExtensionServices.Shared;
using PrismExtensionServices.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;

public class CustomerPut
{
    public Customer[]? data;
}

public class Customer
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
    public long? sbssid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? regionsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? tenantsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? districtsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? storesid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? companysid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? custid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? sharetype;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? lastname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? firstname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? active;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? marketingflag;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? birthday;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? birthmonth;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? birthyear;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? custtype;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? custclasssid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? titlesid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? suffixsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? gender;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? pricelvlsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? taxareasid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? taxarea2sid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? creditlimit;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? creditused;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? storecredit;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? acceptchecks;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? checklimit;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? detax;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? suggesteddiscperc;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? maxdiscperc;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? householdcode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? mark1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? mark2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? securitylvl;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? arflag;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? relatedcustsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? shippingpriority;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? primaryclerksid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? firstsaledate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? lastsaledate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? lastsaleamt;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? wscusername;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? wscpassword;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? paymenttermssid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? accountingsystemid;

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
    public DateTime? udf1date;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? udf2date;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? email;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf1clob;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? udf2clob;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? notes;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? image;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? info1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? info2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? qblink;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? cms;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? lastreturndate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? totaltransactions;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? saleitemcount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? returnitemcount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? segmented;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? employeeascustomer;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? lastorderdate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? orderitemcount;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? station;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? allowedtenders;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? countrysid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? promocustlistname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? alternateid1;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? alternateid2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? ltyoptin;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public DateTime? ltyenrolldate;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? ltybalance;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? ltyaccumulated;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? ltylvlsid;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? ltylvllocked;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? ltyoptinmanual;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<CustomerAddress>? custaddress;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<CustEmail>? custemail;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<CustPhone>? custphone;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<CustExtend>? custextend;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? title;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? region;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxarea;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? taxarea2;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? pricelevel;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? company;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? fullname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custimage;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? sbsname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? sbsno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storename;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? storeno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? custclass;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? primaryclerk;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ltylvlname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? imagepath;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? storecode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? primaryclerkorigsbsno;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? pricelevelname;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? origintimezone;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public decimal? centralcredit;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? centralcurrencycode;


    public void FixLengths()
    {
        this.accountingsystemid = this.accountingsystemid?.SetMaxLength(40);
        this.alternateid1 = this.alternateid1?.SetMaxLength(20);
        this.alternateid2 = this.alternateid2?.SetMaxLength(20);
        this.centralcurrencycode = this.centralcurrencycode?.SetMaxLength(10);
        this.company = this.company?.SetMaxLength(70);
        this.email = this.email?.SetMaxLength(100);
        this.firstname = this.firstname?.SetMaxLength(30);
        this.info1 = this.info1?.SetMaxLength(20);
        this.info2 = this.info2?.SetMaxLength(20);
        this.lastname = this.lastname?.SetMaxLength(30);
        this.mark1 = this.mark1?.SetMaxLength(4);
        this.mark2 = this.mark2?.SetMaxLength(4);
        this.notes = this.notes?.SetMaxLength(2000);
        this.primaryclerk = this.primaryclerk?.SetMaxLength(8);
        this.title = this.title?.SetMaxLength(15);
        this.udf1clob = this.udf1clob?.SetMaxLength(2000);
        this.udf1string = this.udf1string?.SetMaxLength(50);
        this.udf2clob = this.udf2clob?.SetMaxLength(2000);
        this.udf2string = this.udf2string?.SetMaxLength(50);
        this.udf3string = this.udf3string?.SetMaxLength(50);
        this.udf4string = this.udf4string?.SetMaxLength(50);
        this.udf5string = this.udf5string?.SetMaxLength(50);
        this.wscpassword = this.wscpassword?.SetMaxLength(20);
        this.wscusername = this.wscusername?.SetMaxLength(20);

        if (this.custphone != null && this.custphone.Count > 0)
        {
            foreach (var phone in this.custphone)
            {
                phone.phoneno = phone.phoneno?.SetMaxLength(30);
            }
        }
        if (this.custextend != null && this.custextend.Count > 0)
        {
            foreach (var udf in this.custextend)
            {
                udf.udf6string = udf.udf6string?.SetMaxLength(50);
                udf.udf7string = udf.udf7string?.SetMaxLength(50);
                udf.udf8string = udf.udf8string?.SetMaxLength(50);
                udf.udf9string = udf.udf9string?.SetMaxLength(50);
                udf.udf10string = udf.udf10string?.SetMaxLength(50);
                udf.udf11string = udf.udf11string?.SetMaxLength(50);
                udf.udf12string = udf.udf12string?.SetMaxLength(50);
                udf.udf13string = udf.udf13string?.SetMaxLength(50);
                udf.udf14string = udf.udf14string?.SetMaxLength(50);
                udf.udf15string = udf.udf15string?.SetMaxLength(50);
                udf.udf16string = udf.udf16string?.SetMaxLength(50);
                udf.udf17string = udf.udf17string?.SetMaxLength(50);
                udf.udf18string = udf.udf18string?.SetMaxLength(50);
                udf.udf1largestring = udf.udf1largestring?.SetMaxLength(2000);
                udf.udf2largestring = udf.udf2largestring?.SetMaxLength(2000);
            }
        }
        if (this.custemail != null && this.custemail.Count > 0)
        {
            foreach (var custemail in this.custemail)
            {

            }
        }

    }

    public Customer ForUpdate(string defaultEmployeeName, long? defaultEmployeeSid)
    {
        var customer = (Customer)this.MemberwiseClone();

        customer.createdby = null;
        customer.createddatetime = null;
        customer.custaddress = null;
        customer.custemail = null;
        customer.custphone = null;
        customer.custextend = null;

        customer.modifiedby = defaultEmployeeName;
        customer.modifieddatetime = DateTime.Now;

        return customer;

    }
}
