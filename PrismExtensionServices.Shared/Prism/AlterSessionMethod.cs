using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using PrismExtensionServices.Shared.Serialization;

namespace PrismExtensionServices.Shared.Prism;

public class AlterSessionRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? subsidiarysid { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonConverter(typeof(SidConverter))]
    public long? storesid { get; set; }
}





public class Licenseinfo
{
    //[JsonPropertyName("sid")]
    //public string? Sid { get; set; }

    //[JsonPropertyName("productcode")]
    //public string? Productcode { get; set; }

    //[JsonPropertyName("productversion")]
    //public string? Productversion { get; set; }

    //[JsonPropertyName("expirationdate")]
    //public DateTime? Expirationdate { get; set; }

    //[JsonPropertyName("maxstores")]
    //public int? Maxstores { get; set; }

    //[JsonPropertyName("maxsites")]
    //public int? Maxsites { get; set; }

    //[JsonPropertyName("maxseats")]
    //public int? Maxseats { get; set; }

    //[JsonPropertyName("valid")]
    //public bool? Valid { get; set; }

    //[JsonPropertyName("fs_syncstatus")]
    //public int? FsSyncstatus { get; set; }

    //[JsonPropertyName("fs_lastsyncdate")]
    //public DateTime? FsLastsyncdate { get; set; }

    //[JsonPropertyName("fs_nextautosyncdate")]
    //public DateTime? FsNextautosyncdate { get; set; }

    //[JsonPropertyName("fs_nextforcesyncdate")]
    //public DateTime? FsNextforcesyncdate { get; set; }
}

public class Permissions
{
    //[JsonPropertyName("inventoryassemblekits")]
    //public string? Inventoryassemblekits { get; set; }

    //[JsonPropertyName("allowmanualdetax")]
    //public string? Allowmanualdetax { get; set; }

    //[JsonPropertyName("xzoutforcecloseregister")]
    //public string? Xzoutforcecloseregister { get; set; }

    //[JsonPropertyName("departmentcreatecopy")]
    //public string? Departmentcreatecopy { get; set; }

    //[JsonPropertyName("posallowcustomerchangeonfinalizedtran")]
    //public string? Posallowcustomerchangeonfinalizedtran { get; set; }

    //[JsonPropertyName("autotoolsgeneratepurchaseorders")]
    //public string? Autotoolsgeneratepurchaseorders { get; set; }

    //[JsonPropertyName("disbursementschangesubsidiary")]
    //public string? Disbursementschangesubsidiary { get; set; }

    //[JsonPropertyName("purchaseorderchangesubsidiary")]
    //public string? Purchaseorderchangesubsidiary { get; set; }

    //[JsonPropertyName("pcpromoedit")]
    //public string? Pcpromoedit { get; set; }

    //[JsonPropertyName("allowbreakingkits")]
    //public string? Allowbreakingkits { get; set; }

    //[JsonPropertyName("vendorallowmanualentryofudfvalues")]
    //public string? Vendorallowmanualentryofudfvalues { get; set; }

    //[JsonPropertyName("editcustomerchargebalance")]
    //public string? Editcustomerchargebalance { get; set; }

    //[JsonPropertyName("transferordercreatecopy")]
    //public string? Transferordercreatecopy { get; set; }

    //[JsonPropertyName("inventorybreakkits")]
    //public string? Inventorybreakkits { get; set; }

    //[JsonPropertyName("accessstoreoperations")]
    //public string? Accessstoreoperations { get; set; }

    //[JsonPropertyName("poedititemnotes")]
    //public string? Poedititemnotes { get; set; }

    //[JsonPropertyName("inventoryitemeditminmax")]
    //public string? Inventoryitemeditminmax { get; set; }

    //[JsonPropertyName("poslookupzeropriceditems")]
    //public string? Poslookupzeropriceditems { get; set; }

    //[JsonPropertyName("vendorcreatecopy")]
    //public string? Vendorcreatecopy { get; set; }

    //[JsonPropertyName("changecheckinoutdatetime")]
    //public string? Changecheckinoutdatetime { get; set; }

    //[JsonPropertyName("employeeaccountunlock")]
    //public string? Employeeaccountunlock { get; set; }

    //[JsonPropertyName("editsubsidiary")]
    //public string? Editsubsidiary { get; set; }

    //[JsonPropertyName("tenderstakecod")]
    //public string? Tenderstakecod { get; set; }

    //[JsonPropertyName("pizoneunmerge")]
    //public string? Pizoneunmerge { get; set; }

    //[JsonPropertyName("regionalinventoryeditdcsregionalflag")]
    //public string? Regionalinventoryeditdcsregionalflag { get; set; }

    //[JsonPropertyName("poeditnumber")]
    //public string? Poeditnumber { get; set; }

    //[JsonPropertyName("custactivatedeactivate")]
    //public string? Custactivatedeactivate { get; set; }

    //[JsonPropertyName("pmchangesubsidiary")]
    //public string? Pmchangesubsidiary { get; set; }

    //[JsonPropertyName("posoverridereturntenderrestriction")]
    //public string? Posoverridereturntenderrestriction { get; set; }

    //[JsonPropertyName("merchandiseprinttag")]
    //public string? Merchandiseprinttag { get; set; }

    //[JsonPropertyName("posaddprepaidgiftcard")]
    //public string? Posaddprepaidgiftcard { get; set; }

    //[JsonPropertyName("voucherschangesubsidiary")]
    //public string? Voucherschangesubsidiary { get; set; }

    //[JsonPropertyName("lnallowusewhennotininventory")]
    //public string? Lnallowusewhennotininventory { get; set; }

    //[JsonPropertyName("inventoryitemcreatecopy")]
    //public string? Inventoryitemcreatecopy { get; set; }

    //[JsonPropertyName("allowothertendersforreturns")]
    //public string? Allowothertendersforreturns { get; set; }

    //[JsonPropertyName("piaccess")]
    //public string? Piaccess { get; set; }

    //[JsonPropertyName("tendersgivecheck")]
    //public string? Tendersgivecheck { get; set; }

    //[JsonPropertyName("seeloyaltypoints")]
    //public string? Seeloyaltypoints { get; set; }

    //[JsonPropertyName("regionalinventoryeditinvnregionalflag")]
    //public string? Regionalinventoryeditinvnregionalflag { get; set; }

    //[JsonPropertyName("tendersgivedebitcard")]
    //public string? Tendersgivedebitcard { get; set; }

    //[JsonPropertyName("custallowdeactivatewithstorecredit")]
    //public string? Custallowdeactivatewithstorecredit { get; set; }

    //[JsonPropertyName("asnchangesubsidiary")]
    //public string? Asnchangesubsidiary { get; set; }

    //[JsonPropertyName("poschangetaxarea")]
    //public string? Poschangetaxarea { get; set; }

    //[JsonPropertyName("autotoolsconfigureautominmax")]
    //public string? Autotoolsconfigureautominmax { get; set; }

    //[JsonPropertyName("voiditem")]
    //public string? Voiditem { get; set; }

    //[JsonPropertyName("piprintzonesheet")]
    //public string? Piprintzonesheet { get; set; }

    //[JsonPropertyName("tendersgivegiftcard")]
    //public string? Tendersgivegiftcard { get; set; }

    //[JsonPropertyName("asncreatecopy")]
    //public string? Asncreatecopy { get; set; }

    //[JsonPropertyName("editformerposassociate")]
    //public string? Editformerposassociate { get; set; }

    //[JsonPropertyName("purchaseorderchangestore")]
    //public string? Purchaseorderchangestore { get; set; }

    //[JsonPropertyName("importexportallowdataexport")]
    //public string? Importexportallowdataexport { get; set; }

    //[JsonPropertyName("transferverificationaccess")]
    //public string? Transferverificationaccess { get; set; }

    //[JsonPropertyName("pieditpizone")]
    //public string? Pieditpizone { get; set; }

    //[JsonPropertyName("asndeactivatedelete")]
    //public string? Asndeactivatedelete { get; set; }

    //[JsonPropertyName("vouchersallowmissingpackages")]
    //public string? Vouchersallowmissingpackages { get; set; }

    //[JsonPropertyName("slaccesssecureslonmemos")]
    //public string? Slaccesssecureslonmemos { get; set; }

    //[JsonPropertyName("slaccesssecureslonpostransactions")]
    //public string? Slaccesssecureslonpostransactions { get; set; }

    //[JsonPropertyName("vendoraccess")]
    //public string? Vendoraccess { get; set; }

    //[JsonPropertyName("vendoredit")]
    //public string? Vendoredit { get; set; }

    //[JsonPropertyName("voucherseditdocumentdate")]
    //public string? Voucherseditdocumentdate { get; set; }

    //[JsonPropertyName("tendersreturncharge")]
    //public string? Tendersreturncharge { get; set; }

    //[JsonPropertyName("acaccesscorporateregions")]
    //public string? Acaccesscorporateregions { get; set; }

    //[JsonPropertyName("pizonemerge")]
    //public string? Pizonemerge { get; set; }

    //[JsonPropertyName("xzoutopenregister")]
    //public string? Xzoutopenregister { get; set; }

    //[JsonPropertyName("acaccesstouchmenu")]
    //public string? Acaccesstouchmenu { get; set; }

    //[JsonPropertyName("adjaccessadjmemolookup")]
    //public string? Adjaccessadjmemolookup { get; set; }

    //[JsonPropertyName("acaccesscustomizations")]
    //public string? Acaccesscustomizations { get; set; }

    //[JsonPropertyName("tendersgivecash")]
    //public string? Tendersgivecash { get; set; }

    //[JsonPropertyName("vendoractivatedeactivate")]
    //public string? Vendoractivatedeactivate { get; set; }

    //[JsonPropertyName("asnedititemqty")]
    //public string? Asnedititemqty { get; set; }

    //[JsonPropertyName("removediscounts")]
    //public string? Removediscounts { get; set; }

    //[JsonPropertyName("adjmemoscreatecostmemo")]
    //public string? Adjmemoscreatecostmemo { get; set; }

    //[JsonPropertyName("disbursementschangestore")]
    //public string? Disbursementschangestore { get; set; }

    //[JsonPropertyName("inventoryitemeditonhandqty")]
    //public string? Inventoryitemeditonhandqty { get; set; }

    //[JsonPropertyName("tendersreturndebitcard")]
    //public string? Tendersreturndebitcard { get; set; }

    //[JsonPropertyName("inventoryitemassignserialtype")]
    //public string? Inventoryitemassignserialtype { get; set; }

    //[JsonPropertyName("poschangegiftcardexpiredate")]
    //public string? Poschangegiftcardexpiredate { get; set; }

    //[JsonPropertyName("adjchangesubsidiary")]
    //public string? Adjchangesubsidiary { get; set; }

    //[JsonPropertyName("xzouteditzoutdate")]
    //public string? Xzouteditzoutdate { get; set; }

    //[JsonPropertyName("posallowsalesfee")]
    //public string? Posallowsalesfee { get; set; }

    //[JsonPropertyName("autotoolsrunautoto")]
    //public string? Autotoolsrunautoto { get; set; }

    //[JsonPropertyName("managecurrencies")]
    //public string? Managecurrencies { get; set; }

    //[JsonPropertyName("xzoutcloseregister")]
    //public string? Xzoutcloseregister { get; set; }

    //[JsonPropertyName("vendorinvoicecreate")]
    //public string? Vendorinvoicecreate { get; set; }

    //[JsonPropertyName("inventoryitemedit")]
    //public string? Inventoryitemedit { get; set; }

    //[JsonPropertyName("asnedit")]
    //public string? Asnedit { get; set; }

    //[JsonPropertyName("vouchersedit")]
    //public string? Vouchersedit { get; set; }

    //[JsonPropertyName("closeorder")]
    //public string? Closeorder { get; set; }

    //[JsonPropertyName("inventoryitemalloweditstoreohqtywithoutenteringsnorlns")]
    //public string? Inventoryitemalloweditstoreohqtywithoutenteringsnorlns { get; set; }

    //[JsonPropertyName("snallowusewhenalreadyreceived")]
    //public string? Snallowusewhenalreadyreceived { get; set; }

    //[JsonPropertyName("seeitemcost")]
    //public string? Seeitemcost { get; set; }

    //[JsonPropertyName("tendersgivecharge")]
    //public string? Tendersgivecharge { get; set; }

    //[JsonPropertyName("pieditsheet")]
    //public string? Pieditsheet { get; set; }

    //[JsonPropertyName("createsubsidiary")]
    //public string? Createsubsidiary { get; set; }

    //[JsonPropertyName("vendorinvoiceapprove")]
    //public string? Vendorinvoiceapprove { get; set; }

    //[JsonPropertyName("tendersreturngiftcard")]
    //public string? Tendersreturngiftcard { get; set; }

    //[JsonPropertyName("transferorderactivatedeactivate")]
    //public string? Transferorderactivatedeactivate { get; set; }

    //[JsonPropertyName("poseditpending")]
    //public string? Poseditpending { get; set; }

    //[JsonPropertyName("acaccesstransfers")]
    //public string? Acaccesstransfers { get; set; }

    //[JsonPropertyName("transferorderedit")]
    //public string? Transferorderedit { get; set; }

    //[JsonPropertyName("slchangeslonslips")]
    //public string? Slchangeslonslips { get; set; }

    //[JsonPropertyName("posallownegativesalesfee")]
    //public string? Posallownegativesalesfee { get; set; }

    //[JsonPropertyName("asnchangestore")]
    //public string? Asnchangestore { get; set; }

    //[JsonPropertyName("tenderstakegiftcertificate")]
    //public string? Tenderstakegiftcertificate { get; set; }

    //[JsonPropertyName("customerseditcustomer")]
    //public string? Customerseditcustomer { get; set; }

    //[JsonPropertyName("allowvoidtender")]
    //public string? Allowvoidtender { get; set; }

    //[JsonPropertyName("acaccesswsdetails")]
    //public string? Acaccesswsdetails { get; set; }

    //[JsonPropertyName("tendersreturncheck")]
    //public string? Tendersreturncheck { get; set; }

    //[JsonPropertyName("customerchangesubsidiary")]
    //public string? Customerchangesubsidiary { get; set; }

    //[JsonPropertyName("autotoolsgenerateautoto")]
    //public string? Autotoolsgenerateautoto { get; set; }

    //[JsonPropertyName("acaccesssequencing")]
    //public string? Acaccesssequencing { get; set; }

    //[JsonPropertyName("tenderstakestorecredit")]
    //public string? Tenderstakestorecredit { get; set; }

    //[JsonPropertyName("sendsaleadditem")]
    //public string? Sendsaleadditem { get; set; }

    //[JsonPropertyName("snallowusewhenonanotherorderitem")]
    //public string? Snallowusewhenonanotherorderitem { get; set; }

    //[JsonPropertyName("posaccesstransactionlookup")]
    //public string? Posaccesstransactionlookup { get; set; }

    //[JsonPropertyName("transferorderprintheld")]
    //public string? Transferorderprintheld { get; set; }

    //[JsonPropertyName("pcpromoaccess")]
    //public string? Pcpromoaccess { get; set; }

    //[JsonPropertyName("vendorchangesubsidiary")]
    //public string? Vendorchangesubsidiary { get; set; }

    //[JsonPropertyName("manageexchangerates")]
    //public string? Manageexchangerates { get; set; }

    //[JsonPropertyName("tendersreturngiftcertificate")]
    //public string? Tendersreturngiftcertificate { get; set; }

    //[JsonPropertyName("setcustomerarflag")]
    //public string? Setcustomerarflag { get; set; }

    //[JsonPropertyName("adjmemosprintheld")]
    //public string? Adjmemosprintheld { get; set; }

    //[JsonPropertyName("acaccesslanguageandlocale")]
    //public string? Acaccesslanguageandlocale { get; set; }

    //[JsonPropertyName("posaddstoredgiftcard")]
    //public string? Posaddstoredgiftcard { get; set; }

    //[JsonPropertyName("slaccesssecureslonvouchers")]
    //public string? Slaccesssecureslonvouchers { get; set; }

    //[JsonPropertyName("tenderstakecustomtender")]
    //public string? Tenderstakecustomtender { get; set; }

    //[JsonPropertyName("picreatepizone")]
    //public string? Picreatepizone { get; set; }

    //[JsonPropertyName("inventoryitemeditprices")]
    //public string? Inventoryitemeditprices { get; set; }

    //[JsonPropertyName("acctlinkoptionspreferences")]
    //public string? Acctlinkoptionspreferences { get; set; }

    //[JsonPropertyName("groupmodifypermissions")]
    //public string? Groupmodifypermissions { get; set; }

    //[JsonPropertyName("piupdatesheet")]
    //public string? Piupdatesheet { get; set; }

    //[JsonPropertyName("acaccesspurchasing")]
    //public string? Acaccesspurchasing { get; set; }

    //[JsonPropertyName("poschangestore")]
    //public string? Poschangestore { get; set; }

    //[JsonPropertyName("pcpromoactivate")]
    //public string? Pcpromoactivate { get; set; }

    //[JsonPropertyName("groupassignexculdegroupmember")]
    //public string? Groupassignexculdegroupmember { get; set; }

    //[JsonPropertyName("acctlinklogaccess")]
    //public string? Acctlinklogaccess { get; set; }

    //[JsonPropertyName("poedit")]
    //public string? Poedit { get; set; }

    //[JsonPropertyName("posedititemnotes")]
    //public string? Posedititemnotes { get; set; }

    //[JsonPropertyName("loyaltyprogramcreateedit")]
    //public string? Loyaltyprogramcreateedit { get; set; }

    //[JsonPropertyName("autotoolsaccessautopurchasing")]
    //public string? Autotoolsaccessautopurchasing { get; set; }

    //[JsonPropertyName("acaccessmerchandise")]
    //public string? Acaccessmerchandise { get; set; }

    //[JsonPropertyName("transferscreateslip")]
    //public string? Transferscreateslip { get; set; }

    //[JsonPropertyName("transferslipeditdocumentdate")]
    //public string? Transferslipeditdocumentdate { get; set; }

    //[JsonPropertyName("piprintsheet")]
    //public string? Piprintsheet { get; set; }

    //[JsonPropertyName("transferseditformerslip")]
    //public string? Transferseditformerslip { get; set; }

    //[JsonPropertyName("inventorymanagepackages")]
    //public string? Inventorymanagepackages { get; set; }

    //[JsonPropertyName("custchangepricelevel")]
    //public string? Custchangepricelevel { get; set; }

    //[JsonPropertyName("vouchersprintheld")]
    //public string? Vouchersprintheld { get; set; }

    //[JsonPropertyName("transferseditreceiveditems")]
    //public string? Transferseditreceiveditems { get; set; }

    //[JsonPropertyName("tendersgivegiftcertificate")]
    //public string? Tendersgivegiftcertificate { get; set; }

    //[JsonPropertyName("editlockedloyaltylevel")]
    //public string? Editlockedloyaltylevel { get; set; }

    //[JsonPropertyName("adjmemosupdatememo")]
    //public string? Adjmemosupdatememo { get; set; }

    //[JsonPropertyName("slchangeslonpostransactions")]
    //public string? Slchangeslonpostransactions { get; set; }

    //[JsonPropertyName("employeemanagementdeletegroups")]
    //public string? Employeemanagementdeletegroups { get; set; }

    //[JsonPropertyName("acaccessgridformats")]
    //public string? Acaccessgridformats { get; set; }

    //[JsonPropertyName("vouchersreturnvoucher")]
    //public string? Vouchersreturnvoucher { get; set; }

    //[JsonPropertyName("licensingdeactivation")]
    //public string? Licensingdeactivation { get; set; }

    //[JsonPropertyName("departmentchangesubsidiary")]
    //public string? Departmentchangesubsidiary { get; set; }

    //[JsonPropertyName("editformerpostrackingnumber")]
    //public string? Editformerpostrackingnumber { get; set; }

    //[JsonPropertyName("adjmemoscreateqtymemo")]
    //public string? Adjmemoscreateqtymemo { get; set; }

    //[JsonPropertyName("transferorderchangestore")]
    //public string? Transferorderchangestore { get; set; }

    //[JsonPropertyName("pimodifyzonecounts")]
    //public string? Pimodifyzonecounts { get; set; }

    //[JsonPropertyName("pcpromocreate")]
    //public string? Pcpromocreate { get; set; }

    //[JsonPropertyName("customersselectudfvalues")]
    //public string? Customersselectudfvalues { get; set; }

    //[JsonPropertyName("slchangeslonmemos")]
    //public string? Slchangeslonmemos { get; set; }

    //[JsonPropertyName("sopmperformupdate")]
    //public string? Sopmperformupdate { get; set; }

    //[JsonPropertyName("disbursementsprintupdated")]
    //public string? Disbursementsprintupdated { get; set; }

    //[JsonPropertyName("autotoolscalculateautopurchasing")]
    //public string? Autotoolscalculateautopurchasing { get; set; }

    //[JsonPropertyName("sopmseesubsidiaries")]
    //public string? Sopmseesubsidiaries { get; set; }

    //[JsonPropertyName("adjchangestore")]
    //public string? Adjchangestore { get; set; }

    //[JsonPropertyName("transferorderaccess")]
    //public string? Transferorderaccess { get; set; }

    //[JsonPropertyName("merchandiseaccessitemhistory")]
    //public string? Merchandiseaccessitemhistory { get; set; }

    //[JsonPropertyName("tendersgivecod")]
    //public string? Tendersgivecod { get; set; }

    //[JsonPropertyName("checkcentralcreditbal")]
    //public string? Checkcentralcreditbal { get; set; }

    //[JsonPropertyName("fulfillsendsale")]
    //public string? Fulfillsendsale { get; set; }

    //[JsonPropertyName("customerseditinfomarkfields")]
    //public string? Customerseditinfomarkfields { get; set; }

    //[JsonPropertyName("acaccessstoredetails")]
    //public string? Acaccessstoredetails { get; set; }

    //[JsonPropertyName("createstore")]
    //public string? Createstore { get; set; }

    //[JsonPropertyName("xzouteditzoutfilter")]
    //public string? Xzouteditzoutfilter { get; set; }

    //[JsonPropertyName("posallownegativeorderdeposits")]
    //public string? Posallownegativeorderdeposits { get; set; }

    //[JsonPropertyName("tendersgivecustomtender")]
    //public string? Tendersgivecustomtender { get; set; }

    //[JsonPropertyName("tendersreturncentralgiftcard")]
    //public string? Tendersreturncentralgiftcard { get; set; }

    //[JsonPropertyName("asneditvoucherprice")]
    //public string? Asneditvoucherprice { get; set; }

    //[JsonPropertyName("transferverificationmanual")]
    //public string? Transferverificationmanual { get; set; }

    //[JsonPropertyName("acaccesssystem")]
    //public string? Acaccesssystem { get; set; }

    //[JsonPropertyName("tendersreturncod")]
    //public string? Tendersreturncod { get; set; }

    //[JsonPropertyName("transferverificationchangesubsidiary")]
    //public string? Transferverificationchangesubsidiary { get; set; }

    //[JsonPropertyName("timeclockdeletecheckout")]
    //public string? Timeclockdeletecheckout { get; set; }

    //[JsonPropertyName("piupdatestartquantity")]
    //public string? Piupdatestartquantity { get; set; }

    //[JsonPropertyName("editformerdisbursement")]
    //public string? Editformerdisbursement { get; set; }

    //[JsonPropertyName("vouchersreversevoucher")]
    //public string? Vouchersreversevoucher { get; set; }

    //[JsonPropertyName("timeclockchangesubsidiary")]
    //public string? Timeclockchangesubsidiary { get; set; }

    //[JsonPropertyName("xzoutchangesubsidiary")]
    //public string? Xzoutchangesubsidiary { get; set; }

    //[JsonPropertyName("tenderstakecheck")]
    //public string? Tenderstakecheck { get; set; }

    //[JsonPropertyName("customerscreatecustomer")]
    //public string? Customerscreatecustomer { get; set; }

    //[JsonPropertyName("poschangepricelevel")]
    //public string? Poschangepricelevel { get; set; }

    //[JsonPropertyName("acaccesshardware")]
    //public string? Acaccesshardware { get; set; }

    //[JsonPropertyName("asneditvouchercost")]
    //public string? Asneditvouchercost { get; set; }

    //[JsonPropertyName("deletezone")]
    //public string? Deletezone { get; set; }

    //[JsonPropertyName("poprint")]
    //public string? Poprint { get; set; }

    //[JsonPropertyName("poinactivatedelete")]
    //public string? Poinactivatedelete { get; set; }

    //[JsonPropertyName("adjmemoscreatepricememo")]
    //public string? Adjmemoscreatepricememo { get; set; }

    //[JsonPropertyName("inventoryitemalloweditserialandlotnumber")]
    //public string? Inventoryitemalloweditserialandlotnumber { get; set; }

    //[JsonPropertyName("sopmeditmarkdowns")]
    //public string? Sopmeditmarkdowns { get; set; }

    //[JsonPropertyName("voucherseditpending")]
    //public string? Voucherseditpending { get; set; }

    //[JsonPropertyName("employeemanagementchangetill")]
    //public string? Employeemanagementchangetill { get; set; }

    //[JsonPropertyName("poschangeorderfulfillmentstore")]
    //public string? Poschangeorderfulfillmentstore { get; set; }

    //[JsonPropertyName("tendersgivestorecredit")]
    //public string? Tendersgivestorecredit { get; set; }

    //[JsonPropertyName("poinactiveaccess")]
    //public string? Poinactiveaccess { get; set; }

    //[JsonPropertyName("createpostransaction")]
    //public string? Createpostransaction { get; set; }

    //[JsonPropertyName("editcustomersloyaltylevel")]
    //public string? Editcustomersloyaltylevel { get; set; }

    //[JsonPropertyName("tenderstakegiftcard")]
    //public string? Tenderstakegiftcard { get; set; }

    //[JsonPropertyName("voucherseditprice")]
    //public string? Voucherseditprice { get; set; }

    //[JsonPropertyName("accessreceivingarea")]
    //public string? Accessreceivingarea { get; set; }

    //[JsonPropertyName("accessemployeemanagement")]
    //public string? Accessemployeemanagement { get; set; }

    //[JsonPropertyName("tenderstakecentralgiftcard")]
    //public string? Tenderstakecentralgiftcard { get; set; }

    //[JsonPropertyName("acctlinkoptionsinitialize")]
    //public string? Acctlinkoptionsinitialize { get; set; }

    //[JsonPropertyName("timeclockcheckinout")]
    //public string? Timeclockcheckinout { get; set; }

    //[JsonPropertyName("piactivatesheet")]
    //public string? Piactivatesheet { get; set; }

    //[JsonPropertyName("posbypassgeniusced")]
    //public string? Posbypassgeniusced { get; set; }

    //[JsonPropertyName("acaccesstransactions")]
    //public string? Acaccesstransactions { get; set; }

    //[JsonPropertyName("licensingkillsession")]
    //public string? Licensingkillsession { get; set; }

    //[JsonPropertyName("batchreceivingchangesubsidiary")]
    //public string? Batchreceivingchangesubsidiary { get; set; }

    //[JsonPropertyName("xzoutaccessformeraudit")]
    //public string? Xzoutaccessformeraudit { get; set; }

    //[JsonPropertyName("accessmerchandisearea")]
    //public string? Accessmerchandisearea { get; set; }

    //[JsonPropertyName("transferseditformerassociate")]
    //public string? Transferseditformerassociate { get; set; }

    //[JsonPropertyName("allowupdateonlyatpos")]
    //public string? Allowupdateonlyatpos { get; set; }

    //[JsonPropertyName("manuallyadjustloyaltypoints")]
    //public string? Manuallyadjustloyaltypoints { get; set; }

    //[JsonPropertyName("promotionsenablebroadcast")]
    //public string? Promotionsenablebroadcast { get; set; }

    //[JsonPropertyName("autotoolscalculateautominmax")]
    //public string? Autotoolscalculateautominmax { get; set; }

    //[JsonPropertyName("inventoryitemeditcost")]
    //public string? Inventoryitemeditcost { get; set; }

    //[JsonPropertyName("poschangesubsidiary")]
    //public string? Poschangesubsidiary { get; set; }

    //[JsonPropertyName("tendersreturncustomtender")]
    //public string? Tendersreturncustomtender { get; set; }

    //[JsonPropertyName("acaccessemployee")]
    //public string? Acaccessemployee { get; set; }

    //[JsonPropertyName("adjmemosallowbypassfullctlln")]
    //public string? Adjmemosallowbypassfullctlln { get; set; }

    //[JsonPropertyName("autotoolsaccessautoutilities")]
    //public string? Autotoolsaccessautoutilities { get; set; }

    //[JsonPropertyName("poaccess")]
    //public string? Poaccess { get; set; }

    //[JsonPropertyName("regionalinventoryeditvendorregionalflag")]
    //public string? Regionalinventoryeditvendorregionalflag { get; set; }

    //[JsonPropertyName("editemployeecheckinout")]
    //public string? Editemployeecheckinout { get; set; }

    //[JsonPropertyName("acctlinkpostingaccess")]
    //public string? Acctlinkpostingaccess { get; set; }

    //[JsonPropertyName("xzoutrunxoutreport")]
    //public string? Xzoutrunxoutreport { get; set; }

    //[JsonPropertyName("autotoolsconfigureautopurchasing")]
    //public string? Autotoolsconfigureautopurchasing { get; set; }

    //[JsonPropertyName("posspecialorderadditem")]
    //public string? Posspecialorderadditem { get; set; }

    //[JsonPropertyName("adjmemosunholdmemo")]
    //public string? Adjmemosunholdmemo { get; set; }

    //[JsonPropertyName("editformerposdetails")]
    //public string? Editformerposdetails { get; set; }

    //[JsonPropertyName("inventoryallowmanualentryofudfvalues")]
    //public string? Inventoryallowmanualentryofudfvalues { get; set; }

    //[JsonPropertyName("pcpromodeactivate")]
    //public string? Pcpromodeactivate { get; set; }

    //[JsonPropertyName("asnchangeassociate")]
    //public string? Asnchangeassociate { get; set; }

    //[JsonPropertyName("employeechangetill")]
    //public string? Employeechangetill { get; set; }

    //[JsonPropertyName("transferslipreverseslip")]
    //public string? Transferslipreverseslip { get; set; }

    //[JsonPropertyName("transferscopyformerslip")]
    //public string? Transferscopyformerslip { get; set; }

    //[JsonPropertyName("promotionscopy")]
    //public string? Promotionscopy { get; set; }

    //[JsonPropertyName("acaccessconnectionmanager")]
    //public string? Acaccessconnectionmanager { get; set; }

    //[JsonPropertyName("poschangeassociate")]
    //public string? Poschangeassociate { get; set; }

    //[JsonPropertyName("acaccessdaysintransit")]
    //public string? Acaccessdaysintransit { get; set; }

    //[JsonPropertyName("departmentedit")]
    //public string? Departmentedit { get; set; }

    //[JsonPropertyName("adjmemosallowbypassfullctlsn")]
    //public string? Adjmemosallowbypassfullctlsn { get; set; }

    //[JsonPropertyName("adjmemosprintupdated")]
    //public string? Adjmemosprintupdated { get; set; }

    //[JsonPropertyName("tendersreturncash")]
    //public string? Tendersreturncash { get; set; }

    //[JsonPropertyName("pimergeunmergezones")]
    //public string? Pimergeunmergezones { get; set; }

    //[JsonPropertyName("inventoryitemactivate")]
    //public string? Inventoryitemactivate { get; set; }

    //[JsonPropertyName("givedocdiscount")]
    //public string? Givedocdiscount { get; set; }

    //[JsonPropertyName("pocreatecopy")]
    //public string? Pocreatecopy { get; set; }

    //[JsonPropertyName("inventoryitemassignlottype")]
    //public string? Inventoryitemassignlottype { get; set; }

    //[JsonPropertyName("xzoutchangestore")]
    //public string? Xzoutchangestore { get; set; }

    //[JsonPropertyName("timeclockchangestore")]
    //public string? Timeclockchangestore { get; set; }

    //[JsonPropertyName("posspecialorderclose")]
    //public string? Posspecialorderclose { get; set; }

    //[JsonPropertyName("posholdunholdtransaction")]
    //public string? Posholdunholdtransaction { get; set; }

    //[JsonPropertyName("copypostransactionreceipts")]
    //public string? Copypostransactionreceipts { get; set; }

    //[JsonPropertyName("asnprint")]
    //public string? Asnprint { get; set; }

    //[JsonPropertyName("poseditdocumentdate")]
    //public string? Poseditdocumentdate { get; set; }

    //[JsonPropertyName("tendersgivecreditcard")]
    //public string? Tendersgivecreditcard { get; set; }

    //[JsonPropertyName("runreportdesigner")]
    //public string? Runreportdesigner { get; set; }

    //[JsonPropertyName("transferorderchangesubsidiary")]
    //public string? Transferorderchangesubsidiary { get; set; }

    //[JsonPropertyName("voucherscopy")]
    //public string? Voucherscopy { get; set; }

    //[JsonPropertyName("employeeeditcreate")]
    //public string? Employeeeditcreate { get; set; }

    //[JsonPropertyName("asnnegativequantity")]
    //public string? Asnnegativequantity { get; set; }

    //[JsonPropertyName("poschangeitemtaxcode")]
    //public string? Poschangeitemtaxcode { get; set; }

    //[JsonPropertyName("inventoryitemeditordercost")]
    //public string? Inventoryitemeditordercost { get; set; }

    //[JsonPropertyName("posallowupdatewithoutitems")]
    //public string? Posallowupdatewithoutitems { get; set; }

    //[JsonPropertyName("ttkallowaccess")]
    //public string? Ttkallowaccess { get; set; }

    //[JsonPropertyName("acctlinkbatchespost")]
    //public string? Acctlinkbatchespost { get; set; }

    //[JsonPropertyName("viewitemdetails")]
    //public string? Viewitemdetails { get; set; }

    //[JsonPropertyName("picreatesheet")]
    //public string? Picreatesheet { get; set; }

    //[JsonPropertyName("transferslipeditpending")]
    //public string? Transferslipeditpending { get; set; }

    //[JsonPropertyName("voucherscreate")]
    //public string? Voucherscreate { get; set; }

    //[JsonPropertyName("posprintupdated")]
    //public string? Posprintupdated { get; set; }

    //[JsonPropertyName("posadvanceditemlookup")]
    //public string? Posadvanceditemlookup { get; set; }

    //[JsonPropertyName("tenderstakeforeigncurrency")]
    //public string? Tenderstakeforeigncurrency { get; set; }

    //[JsonPropertyName("tendersreturnstorecredit")]
    //public string? Tendersreturnstorecredit { get; set; }

    //[JsonPropertyName("vendorinvoiceaccess")]
    //public string? Vendorinvoiceaccess { get; set; }

    //[JsonPropertyName("licensingchangeallocation")]
    //public string? Licensingchangeallocation { get; set; }

    //[JsonPropertyName("inventoryitemaccess")]
    //public string? Inventoryitemaccess { get; set; }

    //[JsonPropertyName("groupmanagedefinitions")]
    //public string? Groupmanagedefinitions { get; set; }

    //[JsonPropertyName("tendersgiveforeigncurrency")]
    //public string? Tendersgiveforeigncurrency { get; set; }

    //[JsonPropertyName("acaccessdatatypes")]
    //public string? Acaccessdatatypes { get; set; }

    //[JsonPropertyName("allownegcentralcreditbal")]
    //public string? Allownegcentralcreditbal { get; set; }

    //[JsonPropertyName("transferslipprintheld")]
    //public string? Transferslipprintheld { get; set; }

    //[JsonPropertyName("acctlinkbatchesread")]
    //public string? Acctlinkbatchesread { get; set; }

    //[JsonPropertyName("slaccesssecureslonslips")]
    //public string? Slaccesssecureslonslips { get; set; }

    //[JsonPropertyName("orderitem")]
    //public string? Orderitem { get; set; }

    //[JsonPropertyName("unholdotherstransaction")]
    //public string? Unholdotherstransaction { get; set; }

    //[JsonPropertyName("sopmaccessmanager")]
    //public string? Sopmaccessmanager { get; set; }

    //[JsonPropertyName("issuetaxrebate")]
    //public string? Issuetaxrebate { get; set; }

    //[JsonPropertyName("autotoolsaccessautominmax")]
    //public string? Autotoolsaccessautominmax { get; set; }

    //[JsonPropertyName("customerseditaddresses")]
    //public string? Customerseditaddresses { get; set; }

    //[JsonPropertyName("exceedchargelimit")]
    //public string? Exceedchargelimit { get; set; }

    //[JsonPropertyName("tendersreturncreditcard")]
    //public string? Tendersreturncreditcard { get; set; }

    //[JsonPropertyName("vouchersprintupdated")]
    //public string? Vouchersprintupdated { get; set; }

    //[JsonPropertyName("asnflagpackagesreceived")]
    //public string? Asnflagpackagesreceived { get; set; }

    //[JsonPropertyName("tendersgivecentralgiftcard")]
    //public string? Tendersgivecentralgiftcard { get; set; }

    //[JsonPropertyName("adjustmentmemoseditdocumentdate")]
    //public string? Adjustmentmemoseditdocumentdate { get; set; }

    //[JsonPropertyName("poprintheld")]
    //public string? Poprintheld { get; set; }

    //[JsonPropertyName("checkcentralgiftcardbal")]
    //public string? Checkcentralgiftcardbal { get; set; }

    //[JsonPropertyName("acctlinkwizardaccess")]
    //public string? Acctlinkwizardaccess { get; set; }

    //[JsonPropertyName("changeopt-instatus")]
    //public string? ChangeoptInstatus { get; set; }

    //[JsonPropertyName("posalloworderfee")]
    //public string? Posalloworderfee { get; set; }

    //[JsonPropertyName("importexportallowdataimport")]
    //public string? Importexportallowdataimport { get; set; }

    //[JsonPropertyName("inventoryitemdeactivate")]
    //public string? Inventoryitemdeactivate { get; set; }

    //[JsonPropertyName("asngeneratereceivingvoucher")]
    //public string? Asngeneratereceivingvoucher { get; set; }

    //[JsonPropertyName("employeechangesubsidiary")]
    //public string? Employeechangesubsidiary { get; set; }

    //[JsonPropertyName("posreprintfinalizedreceipt")]
    //public string? Posreprintfinalizedreceipt { get; set; }

    //[JsonPropertyName("pimodifyquantity")]
    //public string? Pimodifyquantity { get; set; }

    //[JsonPropertyName("posallowprintinghelddocuments")]
    //public string? Posallowprintinghelddocuments { get; set; }

    //[JsonPropertyName("transferorderprint")]
    //public string? Transferorderprint { get; set; }

    //[JsonPropertyName("xzoutmodifyworkstation")]
    //public string? Xzoutmodifyworkstation { get; set; }

    //[JsonPropertyName("acaccesstaxes")]
    //public string? Acaccesstaxes { get; set; }

    //[JsonPropertyName("slchangeslonvouchers")]
    //public string? Slchangeslonvouchers { get; set; }

    //[JsonPropertyName("removeitemfromposdocument")]
    //public string? Removeitemfromposdocument { get; set; }

    //[JsonPropertyName("giveitemdiscount")]
    //public string? Giveitemdiscount { get; set; }

    //[JsonPropertyName("accessadminconsole")]
    //public string? Accessadminconsole { get; set; }

    //[JsonPropertyName("xzouteditxoutfilter")]
    //public string? Xzouteditxoutfilter { get; set; }

    //[JsonPropertyName("inventoryitemchangesubsidiary")]
    //public string? Inventoryitemchangesubsidiary { get; set; }

    //[JsonPropertyName("editformerposcustomer")]
    //public string? Editformerposcustomer { get; set; }

    //[JsonPropertyName("xzoutaccessformerzout")]
    //public string? Xzoutaccessformerzout { get; set; }

    //[JsonPropertyName("transferslipchangestore")]
    //public string? Transferslipchangestore { get; set; }

    //[JsonPropertyName("adjmemosreversememo")]
    //public string? Adjmemosreversememo { get; set; }

    //[JsonPropertyName("voucherschangeassociate")]
    //public string? Voucherschangeassociate { get; set; }

    //[JsonPropertyName("transferslipprintupdated")]
    //public string? Transferslipprintupdated { get; set; }

    //[JsonPropertyName("acaccessseason")]
    //public string? Acaccessseason { get; set; }

    //[JsonPropertyName("poenterfreeformemailaddress")]
    //public string? Poenterfreeformemailaddress { get; set; }

    //[JsonPropertyName("inventorypromotespecialorderitem")]
    //public string? Inventorypromotespecialorderitem { get; set; }

    //[JsonPropertyName("adjmemoseditformermemo")]
    //public string? Adjmemoseditformermemo { get; set; }

    //[JsonPropertyName("opencashdrawer")]
    //public string? Opencashdrawer { get; set; }

    //[JsonPropertyName("transfersallowhold")]
    //public string? Transfersallowhold { get; set; }

    //[JsonPropertyName("timeclockdeletecheckin")]
    //public string? Timeclockdeletecheckin { get; set; }

    //[JsonPropertyName("autotoolsaccessautoto")]
    //public string? Autotoolsaccessautoto { get; set; }

    //[JsonPropertyName("tenderstakedebitcard")]
    //public string? Tenderstakedebitcard { get; set; }

    //[JsonPropertyName("acaccesscustomers")]
    //public string? Acaccesscustomers { get; set; }

    //[JsonPropertyName("departmentaccess")]
    //public string? Departmentaccess { get; set; }

    //[JsonPropertyName("acctlinkbatchesview")]
    //public string? Acctlinkbatchesview { get; set; }

    //[JsonPropertyName("adjustmentmemoseditpending")]
    //public string? Adjustmentmemoseditpending { get; set; }

    //[JsonPropertyName("sopmdeletemarkdowns")]
    //public string? Sopmdeletemarkdowns { get; set; }

    //[JsonPropertyName("voucherseditcost")]
    //public string? Voucherseditcost { get; set; }

    //[JsonPropertyName("acctlinkbatchesdelete")]
    //public string? Acctlinkbatchesdelete { get; set; }

    //[JsonPropertyName("autotoolsconfigureautoto")]
    //public string? Autotoolsconfigureautoto { get; set; }

    //[JsonPropertyName("disbursementsaccessdisbursementlookup")]
    //public string? Disbursementsaccessdisbursementlookup { get; set; }

    //[JsonPropertyName("commonskipavailabileqtycheck")]
    //public string? Commonskipavailabileqtycheck { get; set; }

    //[JsonPropertyName("vendorinvoiceedit")]
    //public string? Vendorinvoiceedit { get; set; }

    //[JsonPropertyName("snallowusebeforereceived")]
    //public string? Snallowusebeforereceived { get; set; }

    //[JsonPropertyName("createdisbursement")]
    //public string? Createdisbursement { get; set; }

    //[JsonPropertyName("tenderstakecreditcard")]
    //public string? Tenderstakecreditcard { get; set; }

    //[JsonPropertyName("acaccesssublocations")]
    //public string? Acaccesssublocations { get; set; }

    //[JsonPropertyName("editcustomerchargelimit")]
    //public string? Editcustomerchargelimit { get; set; }

    //[JsonPropertyName("poeditponotes")]
    //public string? Poeditponotes { get; set; }

    //[JsonPropertyName("changetaxrebateamount")]
    //public string? Changetaxrebateamount { get; set; }

    //[JsonPropertyName("editformerpostransaction")]
    //public string? Editformerpostransaction { get; set; }

    //[JsonPropertyName("tenderstakecash")]
    //public string? Tenderstakecash { get; set; }

    //[JsonPropertyName("acctlinkbatchesupdate")]
    //public string? Acctlinkbatchesupdate { get; set; }

    //[JsonPropertyName("closesendsale")]
    //public string? Closesendsale { get; set; }

    //[JsonPropertyName("inventorymanagekits")]
    //public string? Inventorymanagekits { get; set; }

    //[JsonPropertyName("resetpassword")]
    //public string? Resetpassword { get; set; }

    //[JsonPropertyName("tenderstakecharge")]
    //public string? Tenderstakecharge { get; set; }

    //[JsonPropertyName("acaccessthemesandlayouts")]
    //public string? Acaccessthemesandlayouts { get; set; }

    //[JsonPropertyName("asnprintheld")]
    //public string? Asnprintheld { get; set; }

    //[JsonPropertyName("piexportsheet")]
    //public string? Piexportsheet { get; set; }

    //[JsonPropertyName("vendorinvoicedelete")]
    //public string? Vendorinvoicedelete { get; set; }

    //[JsonPropertyName("posaccesspendingtransactions")]
    //public string? Posaccesspendingtransactions { get; set; }

    //[JsonPropertyName("vendorinvoicechangesubsidiary")]
    //public string? Vendorinvoicechangesubsidiary { get; set; }

    //[JsonPropertyName("poscanceltransaction")]
    //public string? Poscanceltransaction { get; set; }

    //[JsonPropertyName("changecheckinoutemployee")]
    //public string? Changecheckinoutemployee { get; set; }

    //[JsonPropertyName("posaddcentralgiftcard")]
    //public string? Posaddcentralgiftcard { get; set; }

    //[JsonPropertyName("promotionsdelete")]
    //public string? Promotionsdelete { get; set; }

    //[JsonPropertyName("returnitem")]
    //public string? Returnitem { get; set; }

    //[JsonPropertyName("transfersaccess")]
    //public string? Transfersaccess { get; set; }

    //[JsonPropertyName("slmanagesublocations")]
    //public string? Slmanagesublocations { get; set; }

    //[JsonPropertyName("poschangeitemtaxamount")]
    //public string? Poschangeitemtaxamount { get; set; }

    //[JsonPropertyName("xzoutauditregister")]
    //public string? Xzoutauditregister { get; set; }

    //[JsonPropertyName("voucherschangestore")]
    //public string? Voucherschangestore { get; set; }

    //[JsonPropertyName("transferslipchangesubsidiary")]
    //public string? Transferslipchangesubsidiary { get; set; }

    //[JsonPropertyName("vouchershold")]
    //public string? Vouchershold { get; set; }

    //[JsonPropertyName("adjmemosprintmemo")]
    //public string? Adjmemosprintmemo { get; set; }

    //[JsonPropertyName("returnitemwithoutsource")]
    //public string? Returnitemwithoutsource { get; set; }

    //[JsonPropertyName("poschangecashier")]
    //public string? Poschangecashier { get; set; }

    //[JsonPropertyName("autotoolsupdateautominmax")]
    //public string? Autotoolsupdateautominmax { get; set; }

    //[JsonPropertyName("posspecialorderfulfill")]
    //public string? Posspecialorderfulfill { get; set; }

    //[JsonPropertyName("customerallowmanualentryofudfvalues")]
    //public string? Customerallowmanualentryofudfvalues { get; set; }

    //[JsonPropertyName("xzoutfinalizezoutreport")]
    //public string? Xzoutfinalizezoutreport { get; set; }

    //[JsonPropertyName("acaccessreporting")]
    //public string? Acaccessreporting { get; set; }

    //[JsonPropertyName("tendersreturnforeigncurrency")]
    //public string? Tendersreturnforeigncurrency { get; set; }

    //[JsonPropertyName("posdiscardpendingheldtransactions")]
    //public string? Posdiscardpendingheldtransactions { get; set; }
}

public class Preferences
{
    //[JsonPropertyName("activation_expiration_date_in_days")]
    //public string? ActivationExpirationDateInDays { get; set; }

    //[JsonPropertyName("apply_promotions_based_on_original_price")]
    //public string? ApplyPromotionsBasedOnOriginalPrice { get; set; }

    //[JsonPropertyName("asn_vouchers_copy_received_qty_from_original_qty_on_asn")]
    //public string? AsnVouchersCopyReceivedQtyFromOriginalQtyOnAsn { get; set; }

    //[JsonPropertyName("asn_vouchers_require_all_specified_packages_for_receiving")]
    //public string? AsnVouchersRequireAllSpecifiedPackagesForReceiving { get; set; }

    //[JsonPropertyName("asn_vouchers_require_number_of_packages_for_receiving")]
    //public string? AsnVouchersRequireNumberOfPackagesForReceiving { get; set; }

    //[JsonPropertyName("auto_lock_workstation_timer")]
    //public string? AutoLockWorkstationTimer { get; set; }

    //[JsonPropertyName("auto_lock_workstation_timer_enabled")]
    //public string? AutoLockWorkstationTimerEnabled { get; set; }

    //[JsonPropertyName("automatically_print_update_balanced_document")]
    //public string? AutomaticallyPrintUpdateBalancedDocument { get; set; }

    //[JsonPropertyName("availability_check_voucher")]
    //public string? AvailabilityCheckVoucher { get; set; }

    //[JsonPropertyName("centrals_credit_enabled")]
    //public string? CentralsCreditEnabled { get; set; }

    //[JsonPropertyName("centrals_credit_negative_bal_permitted")]
    //public string? CentralsCreditNegativeBalPermitted { get; set; }

    //[JsonPropertyName("centrals_credit_offline_limit")]
    //public string? CentralsCreditOfflineLimit { get; set; }

    //[JsonPropertyName("centrals_credit_promt_for_cash")]
    //public string? CentralsCreditPromtForCash { get; set; }

    //[JsonPropertyName("centrals_credit_promt_for_cash_less_then")]
    //public string? CentralsCreditPromtForCashLessThen { get; set; }

    //[JsonPropertyName("centrals_credit_purchase_limit")]
    //public string? CentralsCreditPurchaseLimit { get; set; }

    //[JsonPropertyName("centrals_credit_restrict_change_to")]
    //public string? CentralsCreditRestrictChangeTo { get; set; }

    //[JsonPropertyName("centrals_credit_suggest_as_tender")]
    //public string? CentralsCreditSuggestAsTender { get; set; }

    //[JsonPropertyName("centrals_customer_enabled")]
    //public string? CentralsCustomerEnabled { get; set; }

    //[JsonPropertyName("centrals_customer_max_result_set")]
    //public string? CentralsCustomerMaxResultSet { get; set; }

    //[JsonPropertyName("centrals_gift_card_manage_ids_by")]
    //public string? CentralsGiftCardManageIdsBy { get; set; }

    //[JsonPropertyName("centrals_gift_card_mask_card_number")]
    //public string? CentralsGiftCardMaskCardNumber { get; set; }

    //[JsonPropertyName("centrals_gift_cards_allow_manual_entry")]
    //public string? CentralsGiftCardsAllowManualEntry { get; set; }

    //[JsonPropertyName("centrals_gift_cards_beginning_sentinel")]
    //public object CentralsGiftCardsBeginningSentinel { get; set; }

    //[JsonPropertyName("centrals_gift_cards_card_no_element")]
    //public string? CentralsGiftCardsCardNoElement { get; set; }

    //[JsonPropertyName("centrals_gift_cards_card_no_length")]
    //public string? CentralsGiftCardsCardNoLength { get; set; }

    //[JsonPropertyName("centrals_gift_cards_card_no_track")]
    //public string? CentralsGiftCardsCardNoTrack { get; set; }

    //[JsonPropertyName("centrals_gift_cards_card_no_visible")]
    //public string? CentralsGiftCardsCardNoVisible { get; set; }

    //[JsonPropertyName("centrals_gift_cards_element_seperator")]
    //public object CentralsGiftCardsElementSeperator { get; set; }

    //[JsonPropertyName("centrals_gift_cards_enabled")]
    //public string? CentralsGiftCardsEnabled { get; set; }

    //[JsonPropertyName("centrals_gift_cards_generate_central_id")]
    //public string? CentralsGiftCardsGenerateCentralId { get; set; }

    //[JsonPropertyName("centrals_gift_cards_negative_bal_permitted")]
    //public string? CentralsGiftCardsNegativeBalPermitted { get; set; }

    //[JsonPropertyName("centrals_gift_cards_offline_limit")]
    //public string? CentralsGiftCardsOfflineLimit { get; set; }

    //[JsonPropertyName("centrals_gift_cards_promt_for_cash")]
    //public string? CentralsGiftCardsPromtForCash { get; set; }

    //[JsonPropertyName("centrals_gift_cards_promt_for_cash_less_then")]
    //public string? CentralsGiftCardsPromtForCashLessThen { get; set; }

    //[JsonPropertyName("centrals_gift_cards_purchase_limit")]
    //public string? CentralsGiftCardsPurchaseLimit { get; set; }

    //[JsonPropertyName("centrals_gift_cards_restrict_change_to")]
    //public string? CentralsGiftCardsRestrictChangeTo { get; set; }

    //[JsonPropertyName("centrals_gift_cards_track_begin")]
    //public object CentralsGiftCardsTrackBegin { get; set; }

    //[JsonPropertyName("centrals_gift_cards_track_end")]
    //public object CentralsGiftCardsTrackEnd { get; set; }

    //[JsonPropertyName("centrals_returns_enabled")]
    //public string? CentralsReturnsEnabled { get; set; }

    //[JsonPropertyName("centrals_returns_enforce_orig_price_tax")]
    //public string? CentralsReturnsEnforceOrigPriceTax { get; set; }

    //[JsonPropertyName("centrals_returns_max_result_set")]
    //public string? CentralsReturnsMaxResultSet { get; set; }

    //[JsonPropertyName("client_view_path")]
    //public string? ClientViewPath { get; set; }

    //[JsonPropertyName("combine_mixed_documents_when_printing")]
    //public string? CombineMixedDocumentsWhenPrinting { get; set; }

    //[JsonPropertyName("customer_general_allow_duplicate_cust_ids")]
    //public string? CustomerGeneralAllowDuplicateCustIds { get; set; }

    //[JsonPropertyName("customer_general_allow_duplicate_cust_names")]
    //public string? CustomerGeneralAllowDuplicateCustNames { get; set; }

    //[JsonPropertyName("customer_general_append_installation_id_to_custid")]
    //public string? CustomerGeneralAppendInstallationIdToCustid { get; set; }

    //[JsonPropertyName("customer_general_cust_lookup_by")]
    //public string? CustomerGeneralCustLookupBy { get; set; }

    //[JsonPropertyName("customer_general_customer_share_type")]
    //public string? CustomerGeneralCustomerShareType { get; set; }

    //[JsonPropertyName("customer_general_default_cust_lookup_by")]
    //public string? CustomerGeneralDefaultCustLookupBy { get; set; }

    //[JsonPropertyName("customer_general_new_cust_required_fields")]
    //public string? CustomerGeneralNewCustRequiredFields { get; set; }

    //[JsonPropertyName("customer_general_zeroout_taxperc_for_expcust")]
    //public string? CustomerGeneralZerooutTaxpercForExpcust { get; set; }

    //[JsonPropertyName("customer_history_prism_source")]
    //public string? CustomerHistoryPrismSource { get; set; }

    //[JsonPropertyName("customer_history_v9_database")]
    //public string? CustomerHistoryV9Database { get; set; }

    //[JsonPropertyName("customer_locale_address_location_type")]
    //public string? CustomerLocaleAddressLocationType { get; set; }

    //[JsonPropertyName("customer_orders_allow_record_sale")]
    //public string? CustomerOrdersAllowRecordSale { get; set; }

    //[JsonPropertyName("customer_security_check_limit")]
    //public string? CustomerSecurityCheckLimit { get; set; }

    //[JsonPropertyName("customer_security_cust_security_level_sid")]
    //public string? CustomerSecurityCustSecurityLevelSid { get; set; }

    //[JsonPropertyName("customer_security_cust_security_levels")]
    //public string? CustomerSecurityCustSecurityLevels { get; set; }

    //[JsonPropertyName("customer_security_max_discpercent")]
    //public string? CustomerSecurityMaxDiscpercent { get; set; }

    //[JsonPropertyName("default_eft_sid")]
    //public object DefaultEftSid { get; set; }

    //[JsonPropertyName("default_hardware_sid")]
    //public object DefaultHardwareSid { get; set; }

    //[JsonPropertyName("default_language")]
    //public string? DefaultLanguage { get; set; }

    //[JsonPropertyName("default_po_type")]
    //public string? DefaultPoType { get; set; }

    //[JsonPropertyName("default_price_level")]
    //public string? DefaultPriceLevel { get; set; }

    //[JsonPropertyName("default_price_level_name")]
    //public string? DefaultPriceLevelName { get; set; }

    //[JsonPropertyName("default_price_level_sid")]
    //public string? DefaultPriceLevelSid { get; set; }

    //[JsonPropertyName("default_store_name")]
    //public string? DefaultStoreName { get; set; }

    //[JsonPropertyName("default_store_number")]
    //public string? DefaultStoreNumber { get; set; }

    //[JsonPropertyName("default_store_sid")]
    //public string? DefaultStoreSid { get; set; }

    //[JsonPropertyName("default_sub_wks_create")]
    //public string? DefaultSubWksCreate { get; set; }

    //[JsonPropertyName("default_subject_line")]
    //public string? DefaultSubjectLine { get; set; }

    //[JsonPropertyName("default_sublocation_for_adjustment_memo")]
    //public string? DefaultSublocationForAdjustmentMemo { get; set; }

    //[JsonPropertyName("default_sublocation_for_asn")]
    //public string? DefaultSublocationForAsn { get; set; }

    //[JsonPropertyName("default_sublocation_for_pos_transaction")]
    //public string? DefaultSublocationForPosTransaction { get; set; }

    //[JsonPropertyName("default_sublocation_for_slip")]
    //public string? DefaultSublocationForSlip { get; set; }

    //[JsonPropertyName("default_sublocation_for_voucher")]
    //public string? DefaultSublocationForVoucher { get; set; }

    //[JsonPropertyName("default_subsidiary_number")]
    //public string? DefaultSubsidiaryNumber { get; set; }

    //[JsonPropertyName("default_subsidiary_sid")]
    //public string? DefaultSubsidiarySid { get; set; }

    //[JsonPropertyName("default_tax_area_name")]
    //public string? DefaultTaxAreaName { get; set; }

    //[JsonPropertyName("default_tax_area_sid")]
    //public string? DefaultTaxAreaSid { get; set; }

    //[JsonPropertyName("default_tax_area2_name")]
    //public object DefaultTaxArea2Name { get; set; }

    //[JsonPropertyName("default_tax_area2_sid")]
    //public object DefaultTaxArea2Sid { get; set; }

    //[JsonPropertyName("disbursement_req_cash_drop")]
    //public string? DisbursementReqCashDrop { get; set; }

    //[JsonPropertyName("disbursement_req_drawer_open")]
    //public string? DisbursementReqDrawerOpen { get; set; }

    //[JsonPropertyName("disbursement_req_paid_in")]
    //public string? DisbursementReqPaidIn { get; set; }

    //[JsonPropertyName("disbursement_req_paid_out")]
    //public string? DisbursementReqPaidOut { get; set; }

    //[JsonPropertyName("document_print_package_items")]
    //public string? DocumentPrintPackageItems { get; set; }

    //[JsonPropertyName("document_subject_line")]
    //public string? DocumentSubjectLine { get; set; }

    //[JsonPropertyName("documents_customer_lookup_by")]
    //public string? DocumentsCustomerLookupBy { get; set; }

    //[JsonPropertyName("documents_general_allow_only_one_item_type_per_document")]
    //public string? DocumentsGeneralAllowOnlyOneItemTypePerDocument { get; set; }

    //[JsonPropertyName("documents_general_consolidate_items_on_docs")]
    //public string? DocumentsGeneralConsolidateItemsOnDocs { get; set; }

    //[JsonPropertyName("documents_general_item_lookup_by")]
    //public string? DocumentsGeneralItemLookupBy { get; set; }

    //[JsonPropertyName("documents_general_item_note_map_assigned_to_1")]
    //public object DocumentsGeneralItemNoteMapAssignedTo1 { get; set; }

    //[JsonPropertyName("documents_general_item_note_map_assigned_to_10")]
    //public object DocumentsGeneralItemNoteMapAssignedTo10 { get; set; }

    //[JsonPropertyName("documents_general_item_note_map_assigned_to_2")]
    //public object DocumentsGeneralItemNoteMapAssignedTo2 { get; set; }

    //[JsonPropertyName("documents_general_item_note_map_assigned_to_3")]
    //public object DocumentsGeneralItemNoteMapAssignedTo3 { get; set; }

    //[JsonPropertyName("documents_general_item_note_map_assigned_to_4")]
    //public object DocumentsGeneralItemNoteMapAssignedTo4 { get; set; }

    //[JsonPropertyName("documents_general_item_note_map_assigned_to_5")]
    //public object DocumentsGeneralItemNoteMapAssignedTo5 { get; set; }

    //[JsonPropertyName("documents_general_item_note_map_assigned_to_6")]
    //public object DocumentsGeneralItemNoteMapAssignedTo6 { get; set; }

    //[JsonPropertyName("documents_general_item_note_map_assigned_to_7")]
    //public object DocumentsGeneralItemNoteMapAssignedTo7 { get; set; }

    //[JsonPropertyName("documents_general_item_note_map_assigned_to_8")]
    //public object DocumentsGeneralItemNoteMapAssignedTo8 { get; set; }

    //[JsonPropertyName("documents_general_item_note_map_assigned_to_9")]
    //public object DocumentsGeneralItemNoteMapAssignedTo9 { get; set; }

    //[JsonPropertyName("documents_general_mask_values")]
    //public object DocumentsGeneralMaskValues { get; set; }

    //[JsonPropertyName("documents_general_pending_transaction_lookup_default_filter")]
    //public string? DocumentsGeneralPendingTransactionLookupDefaultFilter { get; set; }

    //[JsonPropertyName("documents_general_print_zero_quantity_items")]
    //public string? DocumentsGeneralPrintZeroQuantityItems { get; set; }

    //[JsonPropertyName("documents_general_seq_level_adjustment")]
    //public string? DocumentsGeneralSeqLevelAdjustment { get; set; }

    //[JsonPropertyName("documents_general_seq_level_asn")]
    //public string? DocumentsGeneralSeqLevelAsn { get; set; }

    //[JsonPropertyName("documents_general_seq_level_customer_id")]
    //public string? DocumentsGeneralSeqLevelCustomerId { get; set; }

    //[JsonPropertyName("documents_general_seq_level_customer_orders")]
    //public string? DocumentsGeneralSeqLevelCustomerOrders { get; set; }

    //[JsonPropertyName("documents_general_seq_level_disbursement")]
    //public string? DocumentsGeneralSeqLevelDisbursement { get; set; }

    //[JsonPropertyName("documents_general_seq_level_layaway")]
    //public string? DocumentsGeneralSeqLevelLayaway { get; set; }

    //[JsonPropertyName("documents_general_seq_level_order")]
    //public string? DocumentsGeneralSeqLevelOrder { get; set; }

    //[JsonPropertyName("documents_general_seq_level_po")]
    //public string? DocumentsGeneralSeqLevelPo { get; set; }

    //[JsonPropertyName("documents_general_seq_level_return")]
    //public string? DocumentsGeneralSeqLevelReturn { get; set; }

    //[JsonPropertyName("documents_general_seq_level_sale")]
    //public string? DocumentsGeneralSeqLevelSale { get; set; }

    //[JsonPropertyName("documents_general_seq_level_send_sale")]
    //public string? DocumentsGeneralSeqLevelSendSale { get; set; }

    //[JsonPropertyName("documents_general_seq_level_to")]
    //public string? DocumentsGeneralSeqLevelTo { get; set; }

    //[JsonPropertyName("documents_general_seq_level_transferslip")]
    //public string? DocumentsGeneralSeqLevelTransferslip { get; set; }

    //[JsonPropertyName("documents_general_seq_level_voucher")]
    //public string? DocumentsGeneralSeqLevelVoucher { get; set; }

    //[JsonPropertyName("documents_general_seq_level_zout")]
    //public string? DocumentsGeneralSeqLevelZout { get; set; }

    //[JsonPropertyName("documents_general_use_mask_for_cost")]
    //public string? DocumentsGeneralUseMaskForCost { get; set; }

    //[JsonPropertyName("documents_general_use_mask_for_last_rcvd_date")]
    //public string? DocumentsGeneralUseMaskForLastRcvdDate { get; set; }

    //[JsonPropertyName("documents_general_use_mask_for_price")]
    //public string? DocumentsGeneralUseMaskForPrice { get; set; }

    //[JsonPropertyName("documents_general_workstation_default_item_type")]
    //public string? DocumentsGeneralWorkstationDefaultItemType { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_comments_required_checkinout")]
    //public string? DocumentsReasonCommentsDocCommentsRequiredCheckinout { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_comments_required_cust_store_credit")]
    //public string? DocumentsReasonCommentsDocCommentsRequiredCustStoreCredit { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_comments_required_sales")]
    //public string? DocumentsReasonCommentsDocCommentsRequiredSales { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_comments_required_so")]
    //public string? DocumentsReasonCommentsDocCommentsRequiredSo { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_comments_required_vouchers")]
    //public string? DocumentsReasonCommentsDocCommentsRequiredVouchers { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_note_required_vouchers")]
    //public string? DocumentsReasonCommentsDocNoteRequiredVouchers { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_adjustments")]
    //public string? DocumentsReasonCommentsDocReasonRequiredAdjustments { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_asn")]
    //public string? DocumentsReasonCommentsDocReasonRequiredAsn { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_cash_drop")]
    //public string? DocumentsReasonCommentsDocReasonRequiredCashDrop { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_disbursements")]
    //public string? DocumentsReasonCommentsDocReasonRequiredDisbursements { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_discount")]
    //public string? DocumentsReasonCommentsDocReasonRequiredDiscount { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_drawer_open")]
    //public string? DocumentsReasonCommentsDocReasonRequiredDrawerOpen { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_paid_in")]
    //public string? DocumentsReasonCommentsDocReasonRequiredPaidIn { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_paid_out")]
    //public string? DocumentsReasonCommentsDocReasonRequiredPaidOut { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_po")]
    //public string? DocumentsReasonCommentsDocReasonRequiredPo { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_return")]
    //public string? DocumentsReasonCommentsDocReasonRequiredReturn { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_sales")]
    //public string? DocumentsReasonCommentsDocReasonRequiredSales { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_slips")]
    //public string? DocumentsReasonCommentsDocReasonRequiredSlips { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_to")]
    //public string? DocumentsReasonCommentsDocReasonRequiredTo { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_void")]
    //public string? DocumentsReasonCommentsDocReasonRequiredVoid { get; set; }

    //[JsonPropertyName("documents_reason_comments_doc_reason_required_vouchers")]
    //public string? DocumentsReasonCommentsDocReasonRequiredVouchers { get; set; }

    //[JsonPropertyName("documents_sendsale_tax_location")]
    //public string? DocumentsSendsaleTaxLocation { get; set; }

    //[JsonPropertyName("eft_mw_credit_endpoint")]
    //public string? EftMwCreditEndpoint { get; set; }

    //[JsonPropertyName("eft_mw_credit_schema")]
    //public string? EftMwCreditSchema { get; set; }

    //[JsonPropertyName("eft_mw_display_colors")]
    //public object EftMwDisplayColors { get; set; }

    //[JsonPropertyName("eft_mw_display_options")]
    //public object EftMwDisplayOptions { get; set; }

    //[JsonPropertyName("eft_mw_gift_endpoint")]
    //public string? EftMwGiftEndpoint { get; set; }

    //[JsonPropertyName("eft_mw_gift_schema")]
    //public string? EftMwGiftSchema { get; set; }

    //[JsonPropertyName("eft_mw_logo_location")]
    //public object EftMwLogoLocation { get; set; }

    //[JsonPropertyName("eft_mw_merchant_key")]
    //public object EftMwMerchantKey { get; set; }

    //[JsonPropertyName("eft_mw_merchant_name")]
    //public object EftMwMerchantName { get; set; }

    //[JsonPropertyName("eft_mw_merchant_site_id")]
    //public object EftMwMerchantSiteId { get; set; }

    //[JsonPropertyName("eft_mw_redirect_location")]
    //public object EftMwRedirectLocation { get; set; }

    //[JsonPropertyName("eft_mw_requires_sig_cap")]
    //public string? EftMwRequiresSigCap { get; set; }

    //[JsonPropertyName("eft_mw_sig_cap_floor_limit")]
    //public string? EftMwSigCapFloorLimit { get; set; }

    //[JsonPropertyName("eft_mw_software_name")]
    //public object EftMwSoftwareName { get; set; }

    //[JsonPropertyName("eft_mw_software_version")]
    //public object EftMwSoftwareVersion { get; set; }

    //[JsonPropertyName("eft_mw_terminal_id")]
    //public object EftMwTerminalId { get; set; }

    //[JsonPropertyName("eft_mw_use_genius_device")]
    //public string? EftMwUseGeniusDevice { get; set; }

    //[JsonPropertyName("eft_mw_use_genius_mini_device")]
    //public string? EftMwUseGeniusMiniDevice { get; set; }

    //[JsonPropertyName("eft_mw_web_transaction_server")]
    //public string? EftMwWebTransactionServer { get; set; }

    //[JsonPropertyName("eft_provider")]
    //public string? EftProvider { get; set; }

    //[JsonPropertyName("email_server_authentication_type")]
    //public string? EmailServerAuthenticationType { get; set; }

    //[JsonPropertyName("email_server_format_type")]
    //public string? EmailServerFormatType { get; set; }

    //[JsonPropertyName("email_server_host_name")]
    //public string? EmailServerHostName { get; set; }

    //[JsonPropertyName("email_server_password")]
    //public string? EmailServerPassword { get; set; }

    //[JsonPropertyName("email_server_password_enc")]
    //public object EmailServerPasswordEnc { get; set; }

    //[JsonPropertyName("email_server_sender")]
    //public string? EmailServerSender { get; set; }

    //[JsonPropertyName("email_server_smtp_port")]
    //public string? EmailServerSmtpPort { get; set; }

    //[JsonPropertyName("email_server_use_ssl")]
    //public string? EmailServerUseSsl { get; set; }

    //[JsonPropertyName("email_server_user_name")]
    //public string? EmailServerUserName { get; set; }

    //[JsonPropertyName("employee_general_default_associate_for_new_transactions")]
    //public string? EmployeeGeneralDefaultAssociateForNewTransactions { get; set; }

    //[JsonPropertyName("employee_general_enable_new_employee_as_cust")]
    //public string? EmployeeGeneralEnableNewEmployeeAsCust { get; set; }

    //[JsonPropertyName("employee_general_generate_high_security_receipts_for_adjustments")]
    //public string? EmployeeGeneralGenerateHighSecurityReceiptsForAdjustments { get; set; }

    //[JsonPropertyName("employee_general_generate_high_security_receipts_for_pos")]
    //public string? EmployeeGeneralGenerateHighSecurityReceiptsForPos { get; set; }

    //[JsonPropertyName("employee_general_generate_high_security_receipts_for_transferslips")]
    //public string? EmployeeGeneralGenerateHighSecurityReceiptsForTransferslips { get; set; }

    //[JsonPropertyName("employee_general_generate_high_security_receipts_for_vouchers")]
    //public string? EmployeeGeneralGenerateHighSecurityReceiptsForVouchers { get; set; }

    //[JsonPropertyName("employee_general_new_emp_required_fields")]
    //public string? EmployeeGeneralNewEmpRequiredFields { get; set; }

    //[JsonPropertyName("employee_general_require_comment")]
    //public string? EmployeeGeneralRequireComment { get; set; }

    //[JsonPropertyName("employee_general_require_user_to_select_associate_on_new_transactions")]
    //public string? EmployeeGeneralRequireUserToSelectAssociateOnNewTransactions { get; set; }

    //[JsonPropertyName("employee_general_show_associate_as")]
    //public string? EmployeeGeneralShowAssociateAs { get; set; }

    //[JsonPropertyName("enable_intercompany_transfers")]
    //public string? EnableIntercompanyTransfers { get; set; }

    //[JsonPropertyName("enable_sublocations")]
    //public string? EnableSublocations { get; set; }

    //[JsonPropertyName("enable_touch_screen_select_inputs")]
    //public string? EnableTouchScreenSelectInputs { get; set; }

    //[JsonPropertyName("enforce_password_history")]
    //public string? EnforcePasswordHistory { get; set; }

    //[JsonPropertyName("enforce_strong_password")]
    //public string? EnforceStrongPassword { get; set; }

    //[JsonPropertyName("error_toast_timeout")]
    //public string? ErrorToastTimeout { get; set; }

    //[JsonPropertyName("global_locality_country_code")]
    //public string? GlobalLocalityCountryCode { get; set; }

    //[JsonPropertyName("global_locality_country_name")]
    //public string? GlobalLocalityCountryName { get; set; }

    //[JsonPropertyName("global_locality_language")]
    //public string? GlobalLocalityLanguage { get; set; }

    //[JsonPropertyName("gmail_oauth_access_token")]
    //public object GmailOauthAccessToken { get; set; }

    //[JsonPropertyName("gmail_oauth_account")]
    //public object GmailOauthAccount { get; set; }

    //[JsonPropertyName("gmail_oauth_callback_url")]
    //public object GmailOauthCallbackUrl { get; set; }

    //[JsonPropertyName("gmail_oauth_client_id")]
    //public object GmailOauthClientId { get; set; }

    //[JsonPropertyName("gmail_oauth_client_secret")]
    //public object GmailOauthClientSecret { get; set; }

    //[JsonPropertyName("gmail_oauth_refresh_token")]
    //public object GmailOauthRefreshToken { get; set; }

    //[JsonPropertyName("grid_data")]
    //public string? GridData { get; set; }

    //[JsonPropertyName("hide_default_print_designs")]
    //public string? HideDefaultPrintDesigns { get; set; }

    //[JsonPropertyName("hsr__exit_document")]
    //public string? HsrExitDocument { get; set; }

    //[JsonPropertyName("hsr__open_drawer")]
    //public string? HsrOpenDrawer { get; set; }

    //[JsonPropertyName("hsr__reboot")]
    //public string? HsrReboot { get; set; }

    //[JsonPropertyName("image_display_type")]
    //public string? ImageDisplayType { get; set; }

    //[JsonPropertyName("image_save_directory")]
    //public string? ImageSaveDirectory { get; set; }

    //[JsonPropertyName("image_server")]
    //public object ImageServer { get; set; }

    //[JsonPropertyName("intercompany_ts_generate_doc_upon_update")]
    //public string? IntercompanyTsGenerateDocUponUpdate { get; set; }

    //[JsonPropertyName("inventory_alert_when_item_price_differs_with_style_price")]
    //public string? InventoryAlertWhenItemPriceDiffersWithStylePrice { get; set; }

    //[JsonPropertyName("inventory_allow_duplicate_alu")]
    //public string? InventoryAllowDuplicateAlu { get; set; }

    //[JsonPropertyName("inventory_allow_duplicate_upc")]
    //public string? InventoryAllowDuplicateUpc { get; set; }

    //[JsonPropertyName("inventory_allow_negative_quantities")]
    //public string? InventoryAllowNegativeQuantities { get; set; }

    //[JsonPropertyName("inventory_cost_difference_threshold")]
    //public string? InventoryCostDifferenceThreshold { get; set; }

    //[JsonPropertyName("inventory_costing_method")]
    //public string? InventoryCostingMethod { get; set; }

    //[JsonPropertyName("inventory_default_columns")]
    //public string? InventoryDefaultColumns { get; set; }

    //[JsonPropertyName("inventory_default_commission_code_sid")]
    //public object InventoryDefaultCommissionCodeSid { get; set; }

    //[JsonPropertyName("inventory_default_filters")]
    //public string? InventoryDefaultFilters { get; set; }

    //[JsonPropertyName("inventory_default_maximum_discount")]
    //public string? InventoryDefaultMaximumDiscount { get; set; }

    //[JsonPropertyName("inventory_discount_price_level_sid")]
    //public object InventoryDiscountPriceLevelSid { get; set; }

    //[JsonPropertyName("inventory_enable_alu_sequence")]
    //public string? InventoryEnableAluSequence { get; set; }

    //[JsonPropertyName("inventory_enable_cost_difference_threshold")]
    //public string? InventoryEnableCostDifferenceThreshold { get; set; }

    //[JsonPropertyName("inventory_enable_style_udfs")]
    //public string? InventoryEnableStyleUdfs { get; set; }

    //[JsonPropertyName("inventory_enable_upc_sequence")]
    //public string? InventoryEnableUpcSequence { get; set; }

    //[JsonPropertyName("inventory_general_seq_level_alu")]
    //public string? InventoryGeneralSeqLevelAlu { get; set; }

    //[JsonPropertyName("inventory_general_seq_level_inventory_media")]
    //public string? InventoryGeneralSeqLevelInventoryMedia { get; set; }

    //[JsonPropertyName("inventory_general_seq_level_upc")]
    //public string? InventoryGeneralSeqLevelUpc { get; set; }

    //[JsonPropertyName("inventory_have_margins_affect_cost")]
    //public string? InventoryHaveMarginsAffectCost { get; set; }

    //[JsonPropertyName("inventory_style_definition_field")]
    //public string? InventoryStyleDefinitionField { get; set; }

    //[JsonPropertyName("layaway_orders_allow_record_sale")]
    //public string? LayawayOrdersAllowRecordSale { get; set; }

    //[JsonPropertyName("lock_after_failed_logon_attempts")]
    //public string? LockAfterFailedLogonAttempts { get; set; }

    //[JsonPropertyName("lockout_duration")]
    //public string? LockoutDuration { get; set; }

    //[JsonPropertyName("log_failed_login")]
    //public string? LogFailedLogin { get; set; }

    //[JsonPropertyName("log_password_change")]
    //public string? LogPasswordChange { get; set; }

    //[JsonPropertyName("log_successfull_login")]
    //public string? LogSuccessfullLogin { get; set; }

    //[JsonPropertyName("log_user_group_change")]
    //public string? LogUserGroupChange { get; set; }

    //[JsonPropertyName("markdown_default_update_tiem")]
    //public string? MarkdownDefaultUpdateTiem { get; set; }

    //[JsonPropertyName("merchandise_adjustments_after_memo_update_goto")]
    //public string? MerchandiseAdjustmentsAfterMemoUpdateGoto { get; set; }

    //[JsonPropertyName("merchandise_adjustments_allow_negative_qty_on_qty_memo")]
    //public string? MerchandiseAdjustmentsAllowNegativeQtyOnQtyMemo { get; set; }

    //[JsonPropertyName("merchandise_adjustments_create_price_memo_for_zerooh_qty")]
    //public string? MerchandiseAdjustmentsCreatePriceMemoForZeroohQty { get; set; }

    //[JsonPropertyName("merchandise_adjustments_default_cost_adj_reason")]
    //public string? MerchandiseAdjustmentsDefaultCostAdjReason { get; set; }

    //[JsonPropertyName("merchandise_adjustments_default_price_adj_reason")]
    //public string? MerchandiseAdjustmentsDefaultPriceAdjReason { get; set; }

    //[JsonPropertyName("merchandise_adjustments_default_qty_adj_reason")]
    //public string? MerchandiseAdjustmentsDefaultQtyAdjReason { get; set; }

    //[JsonPropertyName("merchandise_adjustments_require_comment_on_memos")]
    //public string? MerchandiseAdjustmentsRequireCommentOnMemos { get; set; }

    //[JsonPropertyName("merchandise_adjustments_require_cost_adj_reason")]
    //public string? MerchandiseAdjustmentsRequireCostAdjReason { get; set; }

    //[JsonPropertyName("merchandise_adjustments_require_price_adj_reason")]
    //public string? MerchandiseAdjustmentsRequirePriceAdjReason { get; set; }

    //[JsonPropertyName("merchandise_adjustments_require_qty_adj_reason")]
    //public string? MerchandiseAdjustmentsRequireQtyAdjReason { get; set; }

    //[JsonPropertyName("merchandise_adjustments_save_store_qty_on_memos")]
    //public string? MerchandiseAdjustmentsSaveStoreQtyOnMemos { get; set; }

    //[JsonPropertyName("merchandise_adjustments_use_tax_area1_to_calc_pwt_on_memos")]
    //public string? MerchandiseAdjustmentsUseTaxArea1ToCalcPwtOnMemos { get; set; }

    //[JsonPropertyName("merchandise_adjustments_use_tax_area2_to_calc_pwt_on_memos")]
    //public string? MerchandiseAdjustmentsUseTaxArea2ToCalcPwtOnMemos { get; set; }

    //[JsonPropertyName("merchandise_general_item_sid_generation_method")]
    //public string? MerchandiseGeneralItemSidGenerationMethod { get; set; }

    //[JsonPropertyName("merchandise_general_style_sid_generation_method")]
    //public string? MerchandiseGeneralStyleSidGenerationMethod { get; set; }

    //[JsonPropertyName("merchandise_general_use_first_n_characters_for_style_sid")]
    //public string? MerchandiseGeneralUseFirstNCharactersForStyleSid { get; set; }

    //[JsonPropertyName("merchandise_pi_allow_updatepi_with_missing_serial_lot_numbers")]
    //public string? MerchandisePiAllowUpdatepiWithMissingSerialLotNumbers { get; set; }

    //[JsonPropertyName("merchandise_pi_merge_zones_upon_import")]
    //public string? MerchandisePiMergeZonesUponImport { get; set; }

    //[JsonPropertyName("merchandise_pi_prompt_serial_lot_when_add_edit_picount")]
    //public string? MerchandisePiPromptSerialLotWhenAddEditPicount { get; set; }

    //[JsonPropertyName("merchandise_pi_use_pagination_count")]
    //public string? MerchandisePiUsePaginationCount { get; set; }

    //[JsonPropertyName("merchandise_pricing_disc_price_level")]
    //public string? MerchandisePricingDiscPriceLevel { get; set; }

    //[JsonPropertyName("merchandise_pricing_have_margin_effect_price_cost")]
    //public string? MerchandisePricingHaveMarginEffectPriceCost { get; set; }

    //[JsonPropertyName("merchandise_pricing_max_accum_disc_allowed_fornewitems")]
    //public string? MerchandisePricingMaxAccumDiscAllowedFornewitems { get; set; }

    //[JsonPropertyName("merchandise_pricing_max_disc_allowed_for_newitems")]
    //public string? MerchandisePricingMaxDiscAllowedForNewitems { get; set; }

    //[JsonPropertyName("merchandise_pricing_use_seasonal_pricing")]
    //public string? MerchandisePricingUseSeasonalPricing { get; set; }

    //[JsonPropertyName("merchandise_scale_scale_order_display")]
    //public string? MerchandiseScaleScaleOrderDisplay { get; set; }

    //[JsonPropertyName("number_of_segments")]
    //public string? NumberOfSegments { get; set; }

    //[JsonPropertyName("open_cash_drawer_prevents_new_receipt")]
    //public string? OpenCashDrawerPreventsNewReceipt { get; set; }

    //[JsonPropertyName("open_drawer_after_close")]
    //public string? OpenDrawerAfterClose { get; set; }

    //[JsonPropertyName("order_due_days")]
    //public string? OrderDueDays { get; set; }

    //[JsonPropertyName("password_expires_after")]
    //public string? PasswordExpiresAfter { get; set; }

    //[JsonPropertyName("password_minimum_length")]
    //public string? PasswordMinimumLength { get; set; }

    //[JsonPropertyName("password_requires_number")]
    //public string? PasswordRequiresNumber { get; set; }

    //[JsonPropertyName("password_requires_special_characters")]
    //public string? PasswordRequiresSpecialCharacters { get; set; }

    //[JsonPropertyName("password_requires_uppercase_character")]
    //public string? PasswordRequiresUppercaseCharacter { get; set; }

    //[JsonPropertyName("peripherals_output_deniedreceipts_action")]
    //public string? PeripheralsOutputDeniedreceiptsAction { get; set; }

    //[JsonPropertyName("peripherals_output_deniedreceipts_email_design")]
    //public string? PeripheralsOutputDeniedreceiptsEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_deniedreceipts_email_subject")]
    //public string? PeripheralsOutputDeniedreceiptsEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_deniedreceipts_preview_design")]
    //public string? PeripheralsOutputDeniedreceiptsPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_deniedreceipts_print_design")]
    //public string? PeripheralsOutputDeniedreceiptsPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_deniedreceipts_print_printer")]
    //public object PeripheralsOutputDeniedreceiptsPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_documents_action")]
    //public string? PeripheralsOutputDocumentsAction { get; set; }

    //[JsonPropertyName("peripherals_output_documents_email_design")]
    //public string? PeripheralsOutputDocumentsEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_documents_email_subject")]
    //public string? PeripheralsOutputDocumentsEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_documents_preview_design")]
    //public string? PeripheralsOutputDocumentsPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_documents_print_design")]
    //public string? PeripheralsOutputDocumentsPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_documents_print_printer")]
    //public object PeripheralsOutputDocumentsPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_drawerevent_action")]
    //public string? PeripheralsOutputDrawereventAction { get; set; }

    //[JsonPropertyName("peripherals_output_drawerevent_email_design")]
    //public string? PeripheralsOutputDrawereventEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_drawerevent_email_subject")]
    //public string? PeripheralsOutputDrawereventEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_drawerevent_preview_design")]
    //public string? PeripheralsOutputDrawereventPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_drawerevent_print_design")]
    //public string? PeripheralsOutputDrawereventPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_drawerevent_print_printer")]
    //public object PeripheralsOutputDrawereventPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_giftcardbalance_action")]
    //public string? PeripheralsOutputGiftcardbalanceAction { get; set; }

    //[JsonPropertyName("peripherals_output_giftcardbalance_email_design")]
    //public string? PeripheralsOutputGiftcardbalanceEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_giftcardbalance_email_subject")]
    //public string? PeripheralsOutputGiftcardbalanceEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_giftcardbalance_preview_design")]
    //public string? PeripheralsOutputGiftcardbalancePreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_giftcardbalance_print_design")]
    //public string? PeripheralsOutputGiftcardbalancePrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_giftcardbalance_print_printer")]
    //public object PeripheralsOutputGiftcardbalancePrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_invntags_action")]
    //public string? PeripheralsOutputInvntagsAction { get; set; }

    //[JsonPropertyName("peripherals_output_invntags_email_design")]
    //public string? PeripheralsOutputInvntagsEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_invntags_email_subject")]
    //public string? PeripheralsOutputInvntagsEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_invntags_preview_design")]
    //public string? PeripheralsOutputInvntagsPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_invntags_print_design")]
    //public string? PeripheralsOutputInvntagsPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_invntags_print_printer")]
    //public object PeripheralsOutputInvntagsPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_pisheet_action")]
    //public string? PeripheralsOutputPisheetAction { get; set; }

    //[JsonPropertyName("peripherals_output_pisheet_email_design")]
    //public string? PeripheralsOutputPisheetEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_pisheet_email_subject")]
    //public string? PeripheralsOutputPisheetEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_pisheet_preview_design")]
    //public string? PeripheralsOutputPisheetPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_pisheet_print_design")]
    //public string? PeripheralsOutputPisheetPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_pisheet_print_printer")]
    //public object PeripheralsOutputPisheetPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_potags_action")]
    //public string? PeripheralsOutputPotagsAction { get; set; }

    //[JsonPropertyName("peripherals_output_potags_email_design")]
    //public string? PeripheralsOutputPotagsEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_potags_email_subject")]
    //public string? PeripheralsOutputPotagsEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_potags_preview_design")]
    //public string? PeripheralsOutputPotagsPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_potags_print_design")]
    //public string? PeripheralsOutputPotagsPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_potags_print_printer")]
    //public object PeripheralsOutputPotagsPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_purchaseorder_action")]
    //public string? PeripheralsOutputPurchaseorderAction { get; set; }

    //[JsonPropertyName("peripherals_output_purchaseorder_email_design")]
    //public string? PeripheralsOutputPurchaseorderEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_purchaseorder_email_subject")]
    //public string? PeripheralsOutputPurchaseorderEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_purchaseorder_preview_design")]
    //public string? PeripheralsOutputPurchaseorderPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_purchaseorder_print_design")]
    //public string? PeripheralsOutputPurchaseorderPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_purchaseorder_print_printer")]
    //public object PeripheralsOutputPurchaseorderPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_receiving_action")]
    //public string? PeripheralsOutputReceivingAction { get; set; }

    //[JsonPropertyName("peripherals_output_receiving_email_design")]
    //public string? PeripheralsOutputReceivingEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_receiving_email_subject")]
    //public string? PeripheralsOutputReceivingEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_receiving_preview_design")]
    //public string? PeripheralsOutputReceivingPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_receiving_print_design")]
    //public string? PeripheralsOutputReceivingPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_receiving_print_printer")]
    //public object PeripheralsOutputReceivingPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_recvtags_action")]
    //public string? PeripheralsOutputRecvtagsAction { get; set; }

    //[JsonPropertyName("peripherals_output_recvtags_email_design")]
    //public string? PeripheralsOutputRecvtagsEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_recvtags_email_subject")]
    //public string? PeripheralsOutputRecvtagsEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_recvtags_preview_design")]
    //public string? PeripheralsOutputRecvtagsPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_recvtags_print_design")]
    //public string? PeripheralsOutputRecvtagsPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_recvtags_print_printer")]
    //public object PeripheralsOutputRecvtagsPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_sliptags_action")]
    //public string? PeripheralsOutputSliptagsAction { get; set; }

    //[JsonPropertyName("peripherals_output_sliptags_email_design")]
    //public string? PeripheralsOutputSliptagsEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_sliptags_email_subject")]
    //public string? PeripheralsOutputSliptagsEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_sliptags_preview_design")]
    //public string? PeripheralsOutputSliptagsPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_sliptags_print_design")]
    //public string? PeripheralsOutputSliptagsPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_sliptags_print_printer")]
    //public object PeripheralsOutputSliptagsPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_transferslip_action")]
    //public string? PeripheralsOutputTransferslipAction { get; set; }

    //[JsonPropertyName("peripherals_output_transferslip_email_design")]
    //public string? PeripheralsOutputTransferslipEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_transferslip_email_subject")]
    //public string? PeripheralsOutputTransferslipEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_transferslip_preview_design")]
    //public string? PeripheralsOutputTransferslipPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_transferslip_print_design")]
    //public string? PeripheralsOutputTransferslipPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_transferslip_print_printer")]
    //public object PeripheralsOutputTransferslipPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_xout_action")]
    //public string? PeripheralsOutputXoutAction { get; set; }

    //[JsonPropertyName("peripherals_output_xout_email_design")]
    //public string? PeripheralsOutputXoutEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_xout_email_subject")]
    //public string? PeripheralsOutputXoutEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_xout_preview_design")]
    //public string? PeripheralsOutputXoutPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_xout_print_design")]
    //public string? PeripheralsOutputXoutPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_xout_print_printer")]
    //public object PeripheralsOutputXoutPrintPrinter { get; set; }

    //[JsonPropertyName("peripherals_output_zout_action")]
    //public string? PeripheralsOutputZoutAction { get; set; }

    //[JsonPropertyName("peripherals_output_zout_email_design")]
    //public string? PeripheralsOutputZoutEmailDesign { get; set; }

    //[JsonPropertyName("peripherals_output_zout_email_subject")]
    //public string? PeripheralsOutputZoutEmailSubject { get; set; }

    //[JsonPropertyName("peripherals_output_zout_preview_design")]
    //public string? PeripheralsOutputZoutPreviewDesign { get; set; }

    //[JsonPropertyName("peripherals_output_zout_print_design")]
    //public string? PeripheralsOutputZoutPrintDesign { get; set; }

    //[JsonPropertyName("peripherals_output_zout_print_printer")]
    //public object PeripheralsOutputZoutPrintPrinter { get; set; }

    //[JsonPropertyName("physical_inventory_activate_inactive_items_during_piupdate")]
    //public string? PhysicalInventoryActivateInactiveItemsDuringPiupdate { get; set; }

    //[JsonPropertyName("physical_inventory_allow_ln_discrepancies")]
    //public string? PhysicalInventoryAllowLnDiscrepancies { get; set; }

    //[JsonPropertyName("physical_inventory_allow_sn_discrepancies")]
    //public string? PhysicalInventoryAllowSnDiscrepancies { get; set; }

    //[JsonPropertyName("physical_inventory_enable_ln_counts")]
    //public string? PhysicalInventoryEnableLnCounts { get; set; }

    //[JsonPropertyName("physical_inventory_enable_sn_counts")]
    //public string? PhysicalInventoryEnableSnCounts { get; set; }

    //[JsonPropertyName("physical_inventory_send_destination")]
    //public string? PhysicalInventorySendDestination { get; set; }

    //[JsonPropertyName("physical_inventory_type")]
    //public string? PhysicalInventoryType { get; set; }

    //[JsonPropertyName("populate_max_discount_from")]
    //public string? PopulateMaxDiscountFrom { get; set; }

    //[JsonPropertyName("pos_general_prompt_for_decimal_qty_items")]
    //public string? PosGeneralPromptForDecimalQtyItems { get; set; }

    //[JsonPropertyName("pos_hardware_cash_drawer_status_enabled")]
    //public string? PosHardwareCashDrawerStatusEnabled { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_item_fieldname1")]
    //public string? PosHardwareLineDisplayItemFieldname1 { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_item_fieldname2")]
    //public string? PosHardwareLineDisplayItemFieldname2 { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_new_doc_line1_alignment")]
    //public string? PosHardwareLineDisplayNewDocLine1Alignment { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_new_doc_line1_text")]
    //public object PosHardwareLineDisplayNewDocLine1Text { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_new_doc_line2_alignment")]
    //public string? PosHardwareLineDisplayNewDocLine2Alignment { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_new_doc_line2_text")]
    //public object PosHardwareLineDisplayNewDocLine2Text { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_new_item_line1_alignment")]
    //public string? PosHardwareLineDisplayNewItemLine1Alignment { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_new_item_line1_text")]
    //public object PosHardwareLineDisplayNewItemLine1Text { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_new_item_line2_alignment")]
    //public string? PosHardwareLineDisplayNewItemLine2Alignment { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_new_item_line2_text")]
    //public object PosHardwareLineDisplayNewItemLine2Text { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_startup_line1_alignment")]
    //public string? PosHardwareLineDisplayStartupLine1Alignment { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_startup_line1_text")]
    //public string? PosHardwareLineDisplayStartupLine1Text { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_startup_line2_alignment")]
    //public string? PosHardwareLineDisplayStartupLine2Alignment { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_startup_line2_text")]
    //public string? PosHardwareLineDisplayStartupLine2Text { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_total_fieldname1")]
    //public string? PosHardwareLineDisplayTotalFieldname1 { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_total_fieldname2")]
    //public string? PosHardwareLineDisplayTotalFieldname2 { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_total_line1_alignment")]
    //public string? PosHardwareLineDisplayTotalLine1Alignment { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_total_line1_text")]
    //public object PosHardwareLineDisplayTotalLine1Text { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_total_line2_alignment")]
    //public string? PosHardwareLineDisplayTotalLine2Alignment { get; set; }

    //[JsonPropertyName("pos_hardware_line_display_total_line2_text")]
    //public object PosHardwareLineDisplayTotalLine2Text { get; set; }

    //[JsonPropertyName("pos_hardware_shopper_display_description")]
    //public string? PosHardwareShopperDisplayDescription { get; set; }

    //[JsonPropertyName("pos_hardware_use_wedge_barcode_scanner")]
    //public string? PosHardwareUseWedgeBarcodeScanner { get; set; }

    //[JsonPropertyName("pos_loyalty_charge_tax")]
    //public string? PosLoyaltyChargeTax { get; set; }

    //[JsonPropertyName("pos_loyalty_default_level_sid")]
    //public string? PosLoyaltyDefaultLevelSid { get; set; }

    //[JsonPropertyName("pos_loyalty_enabled")]
    //public string? PosLoyaltyEnabled { get; set; }

    //[JsonPropertyName("pos_loyalty_enforce_returning_points")]
    //public string? PosLoyaltyEnforceReturningPoints { get; set; }

    //[JsonPropertyName("pos_loyalty_include_tax")]
    //public string? PosLoyaltyIncludeTax { get; set; }

    //[JsonPropertyName("pos_loyalty_offline_limit")]
    //public string? PosLoyaltyOfflineLimit { get; set; }

    //[JsonPropertyName("pos_loyalty_optin_mode")]
    //public string? PosLoyaltyOptinMode { get; set; }

    //[JsonPropertyName("pos_loyalty_point_decimals")]
    //public string? PosLoyaltyPointDecimals { get; set; }

    //[JsonPropertyName("pos_loyalty_redemption_type")]
    //public string? PosLoyaltyRedemptionType { get; set; }

    //[JsonPropertyName("pos_loyalty_suggest_using_points")]
    //public string? PosLoyaltySuggestUsingPoints { get; set; }

    //[JsonPropertyName("pos_loyalty_use_enroll_date_for_points")]
    //public string? PosLoyaltyUseEnrollDateForPoints { get; set; }

    //[JsonPropertyName("pos_options_fee_shipping_default_shipping_perc")]
    //public string? PosOptionsFeeShippingDefaultShippingPerc { get; set; }

    //[JsonPropertyName("pos_options_fee_shipping_have_default_shipping_perc")]
    //public string? PosOptionsFeeShippingHaveDefaultShippingPerc { get; set; }

    //[JsonPropertyName("pos_options_fee_shipping_include_tax_in_shipping_amt")]
    //public string? PosOptionsFeeShippingIncludeTaxInShippingAmt { get; set; }

    //[JsonPropertyName("pos_options_general_accumulate_manual_discounts")]
    //public string? PosOptionsGeneralAccumulateManualDiscounts { get; set; }

    //[JsonPropertyName("pos_options_general_accumulate_spread_discounts")]
    //public string? PosOptionsGeneralAccumulateSpreadDiscounts { get; set; }

    //[JsonPropertyName("pos_options_general_apply_as_global_discount")]
    //public string? PosOptionsGeneralApplyAsGlobalDiscount { get; set; }

    //[JsonPropertyName("pos_options_general_apply_orig_gd_to_return_items")]
    //public string? PosOptionsGeneralApplyOrigGdToReturnItems { get; set; }

    //[JsonPropertyName("pos_options_general_auto_spread_global_disc_on_orders")]
    //public string? PosOptionsGeneralAutoSpreadGlobalDiscOnOrders { get; set; }

    //[JsonPropertyName("pos_options_general_auto_spread_global_disc_on_receipts")]
    //public string? PosOptionsGeneralAutoSpreadGlobalDiscOnReceipts { get; set; }

    //[JsonPropertyName("pos_options_general_availability_check_customer_order")]
    //public string? PosOptionsGeneralAvailabilityCheckCustomerOrder { get; set; }

    //[JsonPropertyName("pos_options_general_availability_check_layaway_order")]
    //public string? PosOptionsGeneralAvailabilityCheckLayawayOrder { get; set; }

    //[JsonPropertyName("pos_options_general_availability_check_sale")]
    //public string? PosOptionsGeneralAvailabilityCheckSale { get; set; }

    //[JsonPropertyName("pos_options_general_availability_check_send_sale")]
    //public string? PosOptionsGeneralAvailabilityCheckSendSale { get; set; }

    //[JsonPropertyName("pos_options_general_bring_orig_price_from_price_lvl")]
    //public string? PosOptionsGeneralBringOrigPriceFromPriceLvl { get; set; }

    //[JsonPropertyName("pos_options_general_default_discount_type")]
    //public string? PosOptionsGeneralDefaultDiscountType { get; set; }

    //[JsonPropertyName("pos_options_general_disable_display_of_negative_discount_pct")]
    //public string? PosOptionsGeneralDisableDisplayOfNegativeDiscountPct { get; set; }

    //[JsonPropertyName("pos_options_general_discount_based_on")]
    //public string? PosOptionsGeneralDiscountBasedOn { get; set; }

    //[JsonPropertyName("pos_options_general_discount_rounding_method")]
    //public string? PosOptionsGeneralDiscountRoundingMethod { get; set; }

    //[JsonPropertyName("pos_options_general_empl_max_discount_override")]
    //public string? PosOptionsGeneralEmplMaxDiscountOverride { get; set; }

    //[JsonPropertyName("pos_options_general_print_zero_qty_items_on_transactions")]
    //public string? PosOptionsGeneralPrintZeroQtyItemsOnTransactions { get; set; }

    //[JsonPropertyName("pos_options_general_prompt_for_price_on_zero_price_items")]
    //public string? PosOptionsGeneralPromptForPriceOnZeroPriceItems { get; set; }

    //[JsonPropertyName("pos_options_general_restrict_item_disc_not_exceed_spreadable_global_disc_perc")]
    //public string? PosOptionsGeneralRestrictItemDiscNotExceedSpreadableGlobalDiscPerc { get; set; }

    //[JsonPropertyName("pos_options_general_rounding_method")]
    //public string? PosOptionsGeneralRoundingMethod { get; set; }

    //[JsonPropertyName("pos_options_general_rounding_multiplier")]
    //public string? PosOptionsGeneralRoundingMultiplier { get; set; }

    //[JsonPropertyName("pos_options_general_security_receipts_when_drawer_opened_manually")]
    //public string? PosOptionsGeneralSecurityReceiptsWhenDrawerOpenedManually { get; set; }

    //[JsonPropertyName("pos_options_general_security_receipts_when_receipt_progress_exited")]
    //public string? PosOptionsGeneralSecurityReceiptsWhenReceiptProgressExited { get; set; }

    //[JsonPropertyName("pos_options_general_show_discount_reasons_prompt")]
    //public string? PosOptionsGeneralShowDiscountReasonsPrompt { get; set; }

    //[JsonPropertyName("pos_options_general_show_one_item_discount_option")]
    //public string? PosOptionsGeneralShowOneItemDiscountOption { get; set; }

    //[JsonPropertyName("pos_options_general_show_one_item_discount_type")]
    //public string? PosOptionsGeneralShowOneItemDiscountType { get; set; }

    //[JsonPropertyName("pos_options_general_single_item_discount_type")]
    //public string? PosOptionsGeneralSingleItemDiscountType { get; set; }

    //[JsonPropertyName("pos_options_general_tender_types_used_in_rounding")]
    //public string? PosOptionsGeneralTenderTypesUsedInRounding { get; set; }

    //[JsonPropertyName("pos_options_general_transaction_discount_spread_type")]
    //public string? PosOptionsGeneralTransactionDiscountSpreadType { get; set; }

    //[JsonPropertyName("pos_options_general_use_cust_defined_price_lvl")]
    //public string? PosOptionsGeneralUseCustDefinedPriceLvl { get; set; }

    //[JsonPropertyName("pos_options_general_use_doc_sequence_on_security_receipts")]
    //public string? PosOptionsGeneralUseDocSequenceOnSecurityReceipts { get; set; }

    //[JsonPropertyName("pos_options_general_use_forward_based_qty_pricing")]
    //public string? PosOptionsGeneralUseForwardBasedQtyPricing { get; set; }

    //[JsonPropertyName("pos_options_general_use_qty_pricing")]
    //public string? PosOptionsGeneralUseQtyPricing { get; set; }

    //[JsonPropertyName("pos_options_lot_no_deactivate_when_item_depleted")]
    //public string? PosOptionsLotNoDeactivateWhenItemDepleted { get; set; }

    //[JsonPropertyName("pos_options_lot_no_partial_control_prompt_memos")]
    //public string? PosOptionsLotNoPartialControlPromptMemos { get; set; }

    //[JsonPropertyName("pos_options_lot_no_partial_control_prompt_orders")]
    //public string? PosOptionsLotNoPartialControlPromptOrders { get; set; }

    //[JsonPropertyName("pos_options_lot_no_partial_control_prompt_returns")]
    //public string? PosOptionsLotNoPartialControlPromptReturns { get; set; }

    //[JsonPropertyName("pos_options_lot_no_partial_control_prompt_sales")]
    //public string? PosOptionsLotNoPartialControlPromptSales { get; set; }

    //[JsonPropertyName("pos_options_lot_no_partial_control_prompt_send_sale")]
    //public string? PosOptionsLotNoPartialControlPromptSendSale { get; set; }

    //[JsonPropertyName("pos_options_lot_no_partial_control_prompt_transfers")]
    //public string? PosOptionsLotNoPartialControlPromptTransfers { get; set; }

    //[JsonPropertyName("pos_options_lot_no_partial_control_prompt_vouchers")]
    //public string? PosOptionsLotNoPartialControlPromptVouchers { get; set; }

    //[JsonPropertyName("pos_options_packages_kits_count_package_as_single_item")]
    //public string? PosOptionsPackagesKitsCountPackageAsSingleItem { get; set; }

    //[JsonPropertyName("pos_options_packages_kits_print_kit_item_on_transactions")]
    //public string? PosOptionsPackagesKitsPrintKitItemOnTransactions { get; set; }

    //[JsonPropertyName("pos_options_packages_kits_print_kit_item_price_on_transactions")]
    //public string? PosOptionsPackagesKitsPrintKitItemPriceOnTransactions { get; set; }

    //[JsonPropertyName("pos_options_packages_kits_print_package_item_on_transactions")]
    //public string? PosOptionsPackagesKitsPrintPackageItemOnTransactions { get; set; }

    //[JsonPropertyName("pos_options_packages_kits_print_package_item_price_on_transactions")]
    //public string? PosOptionsPackagesKitsPrintPackageItemPriceOnTransactions { get; set; }

    //[JsonPropertyName("pos_options_packages_kits_when_calculating_tax_on_transactions")]
    //public string? PosOptionsPackagesKitsWhenCalculatingTaxOnTransactions { get; set; }

    //[JsonPropertyName("pos_options_pos_flags_note_fields_require_note_on_lost_sales")]
    //public string? PosOptionsPosFlagsNoteFieldsRequireNoteOnLostSales { get; set; }

    //[JsonPropertyName("pos_options_pos_flags_note_fields_require_note_on_order_items")]
    //public string? PosOptionsPosFlagsNoteFieldsRequireNoteOnOrderItems { get; set; }

    //[JsonPropertyName("pos_options_pos_flags_note_fields_require_note_on_return_items")]
    //public string? PosOptionsPosFlagsNoteFieldsRequireNoteOnReturnItems { get; set; }

    //[JsonPropertyName("pos_options_pos_flags_note_fields_require_note_on_sale_items")]
    //public string? PosOptionsPosFlagsNoteFieldsRequireNoteOnSaleItems { get; set; }

    //[JsonPropertyName("pos_options_ser_no_partial_control_prompt_memos")]
    //public string? PosOptionsSerNoPartialControlPromptMemos { get; set; }

    //[JsonPropertyName("pos_options_ser_no_partial_control_prompt_orders")]
    //public string? PosOptionsSerNoPartialControlPromptOrders { get; set; }

    //[JsonPropertyName("pos_options_ser_no_partial_control_prompt_returns")]
    //public string? PosOptionsSerNoPartialControlPromptReturns { get; set; }

    //[JsonPropertyName("pos_options_ser_no_partial_control_prompt_sales")]
    //public string? PosOptionsSerNoPartialControlPromptSales { get; set; }

    //[JsonPropertyName("pos_options_ser_no_partial_control_prompt_send_sale")]
    //public string? PosOptionsSerNoPartialControlPromptSendSale { get; set; }

    //[JsonPropertyName("pos_options_ser_no_partial_control_prompt_transfers")]
    //public string? PosOptionsSerNoPartialControlPromptTransfers { get; set; }

    //[JsonPropertyName("pos_options_ser_no_partial_control_prompt_vouchers")]
    //public string? PosOptionsSerNoPartialControlPromptVouchers { get; set; }

    //[JsonPropertyName("pos_orders_shipping_method")]
    //public object PosOrdersShippingMethod { get; set; }

    //[JsonPropertyName("pos_tenders_accepted_currencies_give")]
    //public object PosTendersAcceptedCurrenciesGive { get; set; }

    //[JsonPropertyName("pos_tenders_accepted_currencies_take")]
    //public object PosTendersAcceptedCurrenciesTake { get; set; }

    //[JsonPropertyName("pos_tenders_checks_allow_cashback")]
    //public string? PosTendersChecksAllowCashback { get; set; }

    //[JsonPropertyName("pos_tenders_checks_allow_eft_receipts_to_print_when_not_in_use")]
    //public string? PosTendersChecksAllowEftReceiptsToPrintWhenNotInUse { get; set; }

    //[JsonPropertyName("pos_tenders_checks_max_cashback_amt")]
    //public string? PosTendersChecksMaxCashbackAmt { get; set; }

    //[JsonPropertyName("pos_tenders_credit_card_auth_code_required")]
    //public string? PosTendersCreditCardAuthCodeRequired { get; set; }

    //[JsonPropertyName("pos_tenders_credit_card_types")]
    //public string? PosTendersCreditCardTypes { get; set; }

    //[JsonPropertyName("pos_tenders_credit_debit_card_allow_cacshback_on_credit_cards")]
    //public string? PosTendersCreditDebitCardAllowCacshbackOnCreditCards { get; set; }

    //[JsonPropertyName("pos_tenders_credit_debit_card_allow_cacshback_on_debit_cards")]
    //public string? PosTendersCreditDebitCardAllowCacshbackOnDebitCards { get; set; }

    //[JsonPropertyName("pos_tenders_credit_debit_card_allow_card_information_to_be_keyed_in")]
    //public string? PosTendersCreditDebitCardAllowCardInformationToBeKeyedIn { get; set; }

    //[JsonPropertyName("pos_tenders_credit_debit_card_allow_eft_receipts_to_print_when_not_in_use")]
    //public string? PosTendersCreditDebitCardAllowEftReceiptsToPrintWhenNotInUse { get; set; }

    //[JsonPropertyName("pos_tenders_credit_debit_card_max_cacshback_amt_on_credit_cards")]
    //public string? PosTendersCreditDebitCardMaxCacshbackAmtOnCreditCards { get; set; }

    //[JsonPropertyName("pos_tenders_credit_debit_card_max_cacshback_amt_on_debit_cards")]
    //public string? PosTendersCreditDebitCardMaxCacshbackAmtOnDebitCards { get; set; }

    //[JsonPropertyName("pos_tenders_credit_debit_card_require_card_verification")]
    //public string? PosTendersCreditDebitCardRequireCardVerification { get; set; }

    //[JsonPropertyName("pos_tenders_credit_debit_card_verification_method")]
    //public string? PosTendersCreditDebitCardVerificationMethod { get; set; }

    //[JsonPropertyName("pos_tenders_customtender_labels")]
    //public string? PosTendersCustomtenderLabels { get; set; }

    //[JsonPropertyName("pos_tenders_default_give_tender")]
    //public string? PosTendersDefaultGiveTender { get; set; }

    //[JsonPropertyName("pos_tenders_default_take_tender")]
    //public string? PosTendersDefaultTakeTender { get; set; }

    //[JsonPropertyName("pos_tenders_eft_check_default_entry_method")]
    //public string? PosTendersEftCheckDefaultEntryMethod { get; set; }

    //[JsonPropertyName("pos_tenders_eft_credit_default_entry_method")]
    //public string? PosTendersEftCreditDefaultEntryMethod { get; set; }

    //[JsonPropertyName("pos_tenders_eft_debit_default_entry_method")]
    //public string? PosTendersEftDebitDefaultEntryMethod { get; set; }

    //[JsonPropertyName("pos_tenders_eft_gift_default_entry_method")]
    //public string? PosTendersEftGiftDefaultEntryMethod { get; set; }

    //[JsonPropertyName("pos_tenders_eft_use_for_check")]
    //public string? PosTendersEftUseForCheck { get; set; }

    //[JsonPropertyName("pos_tenders_eft_use_for_credit")]
    //public string? PosTendersEftUseForCredit { get; set; }

    //[JsonPropertyName("pos_tenders_eft_use_for_debit")]
    //public string? PosTendersEftUseForDebit { get; set; }

    //[JsonPropertyName("pos_tenders_eft_use_for_gift_card")]
    //public string? PosTendersEftUseForGiftCard { get; set; }

    //[JsonPropertyName("pos_tenders_gift_cards_gift_certs_auto_generate_gc_id_numbers")]
    //public string? PosTendersGiftCardsGiftCertsAutoGenerateGcIdNumbers { get; set; }

    //[JsonPropertyName("pos_tenders_gift_cards_gift_certs_auto_generate_gcert_id_number")]
    //public string? PosTendersGiftCardsGiftCertsAutoGenerateGcertIdNumber { get; set; }

    //[JsonPropertyName("pos_tenders_gift_cards_number_max_length")]
    //public string? PosTendersGiftCardsNumberMaxLength { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_cash")]
    //public object PosTendersGivenFieldsCash { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_central_gift_card")]
    //public object PosTendersGivenFieldsCentralGiftCard { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_central_gift_certificate")]
    //public object PosTendersGivenFieldsCentralGiftCertificate { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_central_gift_credit")]
    //public object PosTendersGivenFieldsCentralGiftCredit { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_charge")]
    //public string? PosTendersGivenFieldsCharge { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_check")]
    //public object PosTendersGivenFieldsCheck { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_cod")]
    //public object PosTendersGivenFieldsCod { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_credit_card")]
    //public object PosTendersGivenFieldsCreditCard { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customer_loyalty")]
    //public object PosTendersGivenFieldsCustomerLoyalty { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customtender1")]
    //public object PosTendersGivenFieldsCustomtender1 { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customtender10")]
    //public object PosTendersGivenFieldsCustomtender10 { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customtender2")]
    //public object PosTendersGivenFieldsCustomtender2 { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customtender3")]
    //public object PosTendersGivenFieldsCustomtender3 { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customtender4")]
    //public object PosTendersGivenFieldsCustomtender4 { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customtender5")]
    //public object PosTendersGivenFieldsCustomtender5 { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customtender6")]
    //public object PosTendersGivenFieldsCustomtender6 { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customtender7")]
    //public object PosTendersGivenFieldsCustomtender7 { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customtender8")]
    //public object PosTendersGivenFieldsCustomtender8 { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_customtender9")]
    //public object PosTendersGivenFieldsCustomtender9 { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_debit_card")]
    //public object PosTendersGivenFieldsDebitCard { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_deposit")]
    //public object PosTendersGivenFieldsDeposit { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_foreign_check")]
    //public object PosTendersGivenFieldsForeignCheck { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_foreign_currency")]
    //public object PosTendersGivenFieldsForeignCurrency { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_gift_card")]
    //public object PosTendersGivenFieldsGiftCard { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_gift_certificicate")]
    //public object PosTendersGivenFieldsGiftCertificicate { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_payments")]
    //public object PosTendersGivenFieldsPayments { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_store_credit")]
    //public string? PosTendersGivenFieldsStoreCredit { get; set; }

    //[JsonPropertyName("pos_tenders_given_fields_travelers_check")]
    //public object PosTendersGivenFieldsTravelersCheck { get; set; }

    //[JsonPropertyName("pos_tenders_open_as_modal")]
    //public string? PosTendersOpenAsModal { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_cash")]
    //public object PosTendersReturnFieldsCash { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_central_gift_card")]
    //public object PosTendersReturnFieldsCentralGiftCard { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_central_gift_certificate")]
    //public object PosTendersReturnFieldsCentralGiftCertificate { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_central_gift_credit")]
    //public object PosTendersReturnFieldsCentralGiftCredit { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_charge")]
    //public object PosTendersReturnFieldsCharge { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_check")]
    //public string? PosTendersReturnFieldsCheck { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_cod")]
    //public object PosTendersReturnFieldsCod { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_credit_card")]
    //public string? PosTendersReturnFieldsCreditCard { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customer_loyalty")]
    //public string? PosTendersReturnFieldsCustomerLoyalty { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customtender1")]
    //public object PosTendersReturnFieldsCustomtender1 { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customtender10")]
    //public object PosTendersReturnFieldsCustomtender10 { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customtender2")]
    //public object PosTendersReturnFieldsCustomtender2 { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customtender3")]
    //public object PosTendersReturnFieldsCustomtender3 { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customtender4")]
    //public object PosTendersReturnFieldsCustomtender4 { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customtender5")]
    //public object PosTendersReturnFieldsCustomtender5 { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customtender6")]
    //public object PosTendersReturnFieldsCustomtender6 { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customtender7")]
    //public object PosTendersReturnFieldsCustomtender7 { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customtender8")]
    //public object PosTendersReturnFieldsCustomtender8 { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_customtender9")]
    //public object PosTendersReturnFieldsCustomtender9 { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_debit_card")]
    //public string? PosTendersReturnFieldsDebitCard { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_deposit")]
    //public string? PosTendersReturnFieldsDeposit { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_foreign_check")]
    //public string? PosTendersReturnFieldsForeignCheck { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_foreign_currency")]
    //public string? PosTendersReturnFieldsForeignCurrency { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_gift_card")]
    //public object PosTendersReturnFieldsGiftCard { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_gift_certificicate")]
    //public object PosTendersReturnFieldsGiftCertificicate { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_payments")]
    //public string? PosTendersReturnFieldsPayments { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_store_credit")]
    //public string? PosTendersReturnFieldsStoreCredit { get; set; }

    //[JsonPropertyName("pos_tenders_return_fields_travelers_check")]
    //public object PosTendersReturnFieldsTravelersCheck { get; set; }

    //[JsonPropertyName("pos_tenders_rules_cash")]
    //public string? PosTendersRulesCash { get; set; }

    //[JsonPropertyName("pos_tenders_rules_central_gift_card")]
    //public string? PosTendersRulesCentralGiftCard { get; set; }

    //[JsonPropertyName("pos_tenders_rules_central_gift_certificate")]
    //public string? PosTendersRulesCentralGiftCertificate { get; set; }

    //[JsonPropertyName("pos_tenders_rules_central_gift_credit")]
    //public string? PosTendersRulesCentralGiftCredit { get; set; }

    //[JsonPropertyName("pos_tenders_rules_charge")]
    //public string? PosTendersRulesCharge { get; set; }

    //[JsonPropertyName("pos_tenders_rules_check")]
    //public string? PosTendersRulesCheck { get; set; }

    //[JsonPropertyName("pos_tenders_rules_cod")]
    //public string? PosTendersRulesCod { get; set; }

    //[JsonPropertyName("pos_tenders_rules_credit_card")]
    //public string? PosTendersRulesCreditCard { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customer_loyalty")]
    //public string? PosTendersRulesCustomerLoyalty { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customtender1")]
    //public string? PosTendersRulesCustomtender1 { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customtender10")]
    //public string? PosTendersRulesCustomtender10 { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customtender2")]
    //public string? PosTendersRulesCustomtender2 { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customtender3")]
    //public string? PosTendersRulesCustomtender3 { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customtender4")]
    //public string? PosTendersRulesCustomtender4 { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customtender5")]
    //public string? PosTendersRulesCustomtender5 { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customtender6")]
    //public string? PosTendersRulesCustomtender6 { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customtender7")]
    //public string? PosTendersRulesCustomtender7 { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customtender8")]
    //public string? PosTendersRulesCustomtender8 { get; set; }

    //[JsonPropertyName("pos_tenders_rules_customtender9")]
    //public string? PosTendersRulesCustomtender9 { get; set; }

    //[JsonPropertyName("pos_tenders_rules_debit_card")]
    //public string? PosTendersRulesDebitCard { get; set; }

    //[JsonPropertyName("pos_tenders_rules_deposit")]
    //public string? PosTendersRulesDeposit { get; set; }

    //[JsonPropertyName("pos_tenders_rules_foreign_check")]
    //public string? PosTendersRulesForeignCheck { get; set; }

    //[JsonPropertyName("pos_tenders_rules_foreign_currency")]
    //public string? PosTendersRulesForeignCurrency { get; set; }

    //[JsonPropertyName("pos_tenders_rules_gift_card")]
    //public string? PosTendersRulesGiftCard { get; set; }

    //[JsonPropertyName("pos_tenders_rules_gift_certificicate")]
    //public string? PosTendersRulesGiftCertificicate { get; set; }

    //[JsonPropertyName("pos_tenders_rules_payments")]
    //public string? PosTendersRulesPayments { get; set; }

    //[JsonPropertyName("pos_tenders_rules_store_credit")]
    //public string? PosTendersRulesStoreCredit { get; set; }

    //[JsonPropertyName("pos_tenders_rules_travelers_check")]
    //public string? PosTendersRulesTravelersCheck { get; set; }

    //[JsonPropertyName("pos_tenders_set_give_to_last_take")]
    //public string? PosTendersSetGiveToLastTake { get; set; }

    //[JsonPropertyName("pos_tenders_store_credit_allow_cust_resue_sc_if_partial_balance_available")]
    //public string? PosTendersStoreCreditAllowCustResueScIfPartialBalanceAvailable { get; set; }

    //[JsonPropertyName("pos_tenders_store_credit_auto_generate_sc_id_numbers")]
    //public string? PosTendersStoreCreditAutoGenerateScIdNumbers { get; set; }

    //[JsonPropertyName("pos_tenders_store_credit_max_sc_amt_store_tab")]
    //public string? PosTendersStoreCreditMaxScAmtStoreTab { get; set; }

    //[JsonPropertyName("pos_tenders_store_credit_suggest_sc_tender")]
    //public string? PosTendersStoreCreditSuggestScTender { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_cash")]
    //public object PosTendersTakenFieldsCash { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_central_gift_card")]
    //public object PosTendersTakenFieldsCentralGiftCard { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_central_gift_certificate")]
    //public object PosTendersTakenFieldsCentralGiftCertificate { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_central_gift_credit")]
    //public object PosTendersTakenFieldsCentralGiftCredit { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_charge")]
    //public string? PosTendersTakenFieldsCharge { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_check")]
    //public object PosTendersTakenFieldsCheck { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_cod")]
    //public object PosTendersTakenFieldsCod { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_credit_card")]
    //public object PosTendersTakenFieldsCreditCard { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customer_loyalty")]
    //public object PosTendersTakenFieldsCustomerLoyalty { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customtender1")]
    //public object PosTendersTakenFieldsCustomtender1 { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customtender10")]
    //public object PosTendersTakenFieldsCustomtender10 { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customtender2")]
    //public object PosTendersTakenFieldsCustomtender2 { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customtender3")]
    //public object PosTendersTakenFieldsCustomtender3 { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customtender4")]
    //public object PosTendersTakenFieldsCustomtender4 { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customtender5")]
    //public object PosTendersTakenFieldsCustomtender5 { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customtender6")]
    //public object PosTendersTakenFieldsCustomtender6 { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customtender7")]
    //public object PosTendersTakenFieldsCustomtender7 { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customtender8")]
    //public object PosTendersTakenFieldsCustomtender8 { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_customtender9")]
    //public object PosTendersTakenFieldsCustomtender9 { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_debit_card")]
    //public object PosTendersTakenFieldsDebitCard { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_foreign_check")]
    //public object PosTendersTakenFieldsForeignCheck { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_foreign_currency")]
    //public object PosTendersTakenFieldsForeignCurrency { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_gift_card")]
    //public object PosTendersTakenFieldsGiftCard { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_gift_certificicate")]
    //public object PosTendersTakenFieldsGiftCertificicate { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_payments")]
    //public object PosTendersTakenFieldsPayments { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_store_credit")]
    //public string? PosTendersTakenFieldsStoreCredit { get; set; }

    //[JsonPropertyName("pos_tenders_taken_fields_travelers_check")]
    //public object PosTendersTakenFieldsTravelersCheck { get; set; }

    //[JsonPropertyName("pos_tenders_udf_given_customtender1")]
    //public string? PosTendersUdfGivenCustomtender1 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_given_customtender10")]
    //public string? PosTendersUdfGivenCustomtender10 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_given_customtender2")]
    //public string? PosTendersUdfGivenCustomtender2 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_given_customtender3")]
    //public string? PosTendersUdfGivenCustomtender3 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_given_customtender4")]
    //public string? PosTendersUdfGivenCustomtender4 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_given_customtender5")]
    //public string? PosTendersUdfGivenCustomtender5 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_given_customtender6")]
    //public string? PosTendersUdfGivenCustomtender6 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_given_customtender7")]
    //public string? PosTendersUdfGivenCustomtender7 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_given_customtender8")]
    //public string? PosTendersUdfGivenCustomtender8 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_given_customtender9")]
    //public string? PosTendersUdfGivenCustomtender9 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_labels_customtender1")]
    //public object PosTendersUdfLabelsCustomtender1 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_labels_customtender10")]
    //public object PosTendersUdfLabelsCustomtender10 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_labels_customtender2")]
    //public object PosTendersUdfLabelsCustomtender2 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_labels_customtender3")]
    //public object PosTendersUdfLabelsCustomtender3 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_labels_customtender4")]
    //public object PosTendersUdfLabelsCustomtender4 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_labels_customtender5")]
    //public object PosTendersUdfLabelsCustomtender5 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_labels_customtender6")]
    //public object PosTendersUdfLabelsCustomtender6 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_labels_customtender7")]
    //public object PosTendersUdfLabelsCustomtender7 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_labels_customtender8")]
    //public object PosTendersUdfLabelsCustomtender8 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_labels_customtender9")]
    //public object PosTendersUdfLabelsCustomtender9 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_taken_customtender1")]
    //public string? PosTendersUdfTakenCustomtender1 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_taken_customtender10")]
    //public string? PosTendersUdfTakenCustomtender10 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_taken_customtender2")]
    //public string? PosTendersUdfTakenCustomtender2 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_taken_customtender3")]
    //public string? PosTendersUdfTakenCustomtender3 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_taken_customtender4")]
    //public string? PosTendersUdfTakenCustomtender4 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_taken_customtender5")]
    //public string? PosTendersUdfTakenCustomtender5 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_taken_customtender6")]
    //public string? PosTendersUdfTakenCustomtender6 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_taken_customtender7")]
    //public string? PosTendersUdfTakenCustomtender7 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_taken_customtender8")]
    //public string? PosTendersUdfTakenCustomtender8 { get; set; }

    //[JsonPropertyName("pos_tenders_udf_taken_customtender9")]
    //public string? PosTendersUdfTakenCustomtender9 { get; set; }

    //[JsonPropertyName("postal_code_city")]
    //public string? PostalCodeCity { get; set; }

    //[JsonPropertyName("postal_code_enable")]
    //public string? PostalCodeEnable { get; set; }

    //[JsonPropertyName("postal_code_state")]
    //public string? PostalCodeState { get; set; }

    //[JsonPropertyName("postal_code_state_format")]
    //public string? PostalCodeStateFormat { get; set; }

    //[JsonPropertyName("price_plan_authority")]
    //public object PricePlanAuthority { get; set; }

    //[JsonPropertyName("promotions_activate_gift_cards_for_original_amount")]
    //public string? PromotionsActivateGiftCardsForOriginalAmount { get; set; }

    //[JsonPropertyName("prompt_before_expiration")]
    //public string? PromptBeforeExpiration { get; set; }

    //[JsonPropertyName("prompt_for_customer_share_type")]
    //public string? PromptForCustomerShareType { get; set; }

    //[JsonPropertyName("purchase_order_instruction_five")]
    //public object PurchaseOrderInstructionFive { get; set; }

    //[JsonPropertyName("purchase_order_instruction_four")]
    //public object PurchaseOrderInstructionFour { get; set; }

    //[JsonPropertyName("purchase_order_instruction_one")]
    //public object PurchaseOrderInstructionOne { get; set; }

    //[JsonPropertyName("purchase_order_instruction_three")]
    //public object PurchaseOrderInstructionThree { get; set; }

    //[JsonPropertyName("purchase_order_instruction_two")]
    //public object PurchaseOrderInstructionTwo { get; set; }

    //[JsonPropertyName("purchase_order_voucher_fee_types")]
    //public object PurchaseOrderVoucherFeeTypes { get; set; }

    //[JsonPropertyName("purchase_order_voucher_instructions")]
    //public object PurchaseOrderVoucherInstructions { get; set; }

    //[JsonPropertyName("purchasing_after_voucher_updated_go_to")]
    //public string? PurchasingAfterVoucherUpdatedGoTo { get; set; }

    //[JsonPropertyName("purchasing_allow_negative_quantities")]
    //public string? PurchasingAllowNegativeQuantities { get; set; }

    //[JsonPropertyName("purchasing_allow_negative_quantities_on_vouchers")]
    //public string? PurchasingAllowNegativeQuantitiesOnVouchers { get; set; }

    //[JsonPropertyName("purchasing_allow_receiving_after_cancel_date")]
    //public string? PurchasingAllowReceivingAfterCancelDate { get; set; }

    //[JsonPropertyName("purchasing_allow_voucher_update_inventory_prices")]
    //public string? PurchasingAllowVoucherUpdateInventoryPrices { get; set; }

    //[JsonPropertyName("purchasing_case_rounding_method")]
    //public string? PurchasingCaseRoundingMethod { get; set; }

    //[JsonPropertyName("purchasing_cost_to_use")]
    //public string? PurchasingCostToUse { get; set; }

    //[JsonPropertyName("purchasing_inventory_costing_method")]
    //public string? PurchasingInventoryCostingMethod { get; set; }

    //[JsonPropertyName("purchasing_limit_voucher_against_po_only_items_on_po")]
    //public string? PurchasingLimitVoucherAgainstPoOnlyItemsOnPo { get; set; }

    //[JsonPropertyName("purchasing_order_by_case_only")]
    //public string? PurchasingOrderByCaseOnly { get; set; }

    //[JsonPropertyName("purchasing_require_all_specified_packages_to_be_received")]
    //public string? PurchasingRequireAllSpecifiedPackagesToBeReceived { get; set; }

    //[JsonPropertyName("purchasing_require_number_of_packages_to_be_received")]
    //public string? PurchasingRequireNumberOfPackagesToBeReceived { get; set; }

    //[JsonPropertyName("purchasing_require_receive_voucher_reference_po")]
    //public string? PurchasingRequireReceiveVoucherReferencePo { get; set; }

    //[JsonPropertyName("purchasing_require_return_voucher_reference_po")]
    //public string? PurchasingRequireReturnVoucherReferencePo { get; set; }

    //[JsonPropertyName("purchasing_restrict_one_vendor_per_po_voucher")]
    //public string? PurchasingRestrictOneVendorPerPoVoucher { get; set; }

    //[JsonPropertyName("purchasing_use_vendor_invoices")]
    //public string? PurchasingUseVendorInvoices { get; set; }

    //[JsonPropertyName("purchasing_vouchers_consolidate_like_items")]
    //public string? PurchasingVouchersConsolidateLikeItems { get; set; }

    //[JsonPropertyName("regional_inventory_create_departments_as_regional")]
    //public string? RegionalInventoryCreateDepartmentsAsRegional { get; set; }

    //[JsonPropertyName("regional_inventory_create_items_as_regional")]
    //public string? RegionalInventoryCreateItemsAsRegional { get; set; }

    //[JsonPropertyName("regional_inventory_create_vendors_as_regional")]
    //public string? RegionalInventoryCreateVendorsAsRegional { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_alu")]
    //public string? RegionalInventoryPropagateItemAlu { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_costs")]
    //public string? RegionalInventoryPropagateItemCosts { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_desc3")]
    //public string? RegionalInventoryPropagateItemDesc3 { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_desc4")]
    //public string? RegionalInventoryPropagateItemDesc4 { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_prices")]
    //public string? RegionalInventoryPropagateItemPrices { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_scale")]
    //public string? RegionalInventoryPropagateItemScale { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_taxes")]
    //public string? RegionalInventoryPropagateItemTaxes { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_udfs")]
    //public string? RegionalInventoryPropagateItemUdfs { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_unorderable")]
    //public string? RegionalInventoryPropagateItemUnorderable { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_upc")]
    //public string? RegionalInventoryPropagateItemUpc { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_use_exchangerate_for_cost")]
    //public string? RegionalInventoryPropagateItemUseExchangerateForCost { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_use_exchangerate_for_cost_rounddecimal")]
    //public string? RegionalInventoryPropagateItemUseExchangerateForCostRounddecimal { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_use_exchangerate_for_price")]
    //public string? RegionalInventoryPropagateItemUseExchangerateForPrice { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_item_use_exchangerate_for_price_rounddecimal")]
    //public string? RegionalInventoryPropagateItemUseExchangerateForPriceRounddecimal { get; set; }

    //[JsonPropertyName("regional_inventory_propagate_vendor_udfs")]
    //public string? RegionalInventoryPropagateVendorUdfs { get; set; }

    //[JsonPropertyName("regional_settings_am")]
    //public string? RegionalSettingsAm { get; set; }

    //[JsonPropertyName("regional_settings_currency_gsize")]
    //public string? RegionalSettingsCurrencyGsize { get; set; }

    //[JsonPropertyName("regional_settings_currency_lgsize")]
    //public string? RegionalSettingsCurrencyLgsize { get; set; }

    //[JsonPropertyName("regional_settings_currency_symbol")]
    //public string? RegionalSettingsCurrencySymbol { get; set; }

    //[JsonPropertyName("regional_settings_currency_symbol_position")]
    //public string? RegionalSettingsCurrencySymbolPosition { get; set; }

    //[JsonPropertyName("regional_settings_custom_settings_flag")]
    //public string? RegionalSettingsCustomSettingsFlag { get; set; }

    //[JsonPropertyName("regional_settings_date_format")]
    //public string? RegionalSettingsDateFormat { get; set; }

    //[JsonPropertyName("regional_settings_date_time_format")]
    //public string? RegionalSettingsDateTimeFormat { get; set; }

    //[JsonPropertyName("regional_settings_decimal_character")]
    //public string? RegionalSettingsDecimalCharacter { get; set; }

    //[JsonPropertyName("regional_settings_decimal_spaces_cost")]
    //public string? RegionalSettingsDecimalSpacesCost { get; set; }

    //[JsonPropertyName("regional_settings_decimal_spaces_currency")]
    //public string? RegionalSettingsDecimalSpacesCurrency { get; set; }

    //[JsonPropertyName("regional_settings_decimal_spaces_number")]
    //public string? RegionalSettingsDecimalSpacesNumber { get; set; }

    //[JsonPropertyName("regional_settings_decimal_spaces_price")]
    //public string? RegionalSettingsDecimalSpacesPrice { get; set; }

    //[JsonPropertyName("regional_settings_decimal_spaces_tax")]
    //public string? RegionalSettingsDecimalSpacesTax { get; set; }

    //[JsonPropertyName("regional_settings_group_separator")]
    //public string? RegionalSettingsGroupSeparator { get; set; }

    //[JsonPropertyName("regional_settings_i18n")]
    //public object RegionalSettingsI18n { get; set; }

    //[JsonPropertyName("regional_settings_number_gsize")]
    //public string? RegionalSettingsNumberGsize { get; set; }

    //[JsonPropertyName("regional_settings_number_lgsize")]
    //public string? RegionalSettingsNumberLgsize { get; set; }

    //[JsonPropertyName("regional_settings_pm")]
    //public string? RegionalSettingsPm { get; set; }

    //[JsonPropertyName("regional_settings_region")]
    //public string? RegionalSettingsRegion { get; set; }

    //[JsonPropertyName("regional_settings_show_currency_symbol")]
    //public string? RegionalSettingsShowCurrencySymbol { get; set; }

    //[JsonPropertyName("regional_settings_show_offset")]
    //public string? RegionalSettingsShowOffset { get; set; }

    //[JsonPropertyName("regional_settings_time_format")]
    //public string? RegionalSettingsTimeFormat { get; set; }

    //[JsonPropertyName("regional_settings_time_zone")]
    //public string? RegionalSettingsTimeZone { get; set; }

    //[JsonPropertyName("require_check_in_for_document_creation")]
    //public string? RequireCheckInForDocumentCreation { get; set; }

    //[JsonPropertyName("run_prism_standalone")]
    //public string? RunPrismStandalone { get; set; }

    //[JsonPropertyName("sequencing_sequence_rules_auto_generate_po_number")]
    //public string? SequencingSequenceRulesAutoGeneratePoNumber { get; set; }

    //[JsonPropertyName("sequencing_sequence_rules_use_doc_seq_on_high_security_receipts")]
    //public string? SequencingSequenceRulesUseDocSeqOnHighSecurityReceipts { get; set; }

    //[JsonPropertyName("sequencing_sequence_rules_use_separate_seq_for_all_order_types")]
    //public string? SequencingSequenceRulesUseSeparateSeqForAllOrderTypes { get; set; }

    //[JsonPropertyName("sequencing_sequence_rules_use_separate_seq_for_all_receipt_types")]
    //public string? SequencingSequenceRulesUseSeparateSeqForAllReceiptTypes { get; set; }

    //[JsonPropertyName("sequencing_sequence_rules_use_separate_seq_for_multi_single_sbs_po")]
    //public string? SequencingSequenceRulesUseSeparateSeqForMultiSingleSbsPo { get; set; }

    //[JsonPropertyName("sequencing_sequence_rules_use_separate_seq_for_receiving_return_vouchers")]
    //public string? SequencingSequenceRulesUseSeparateSeqForReceivingReturnVouchers { get; set; }

    //[JsonPropertyName("set_expiration_date_upon_activation")]
    //public string? SetExpirationDateUponActivation { get; set; }

    //[JsonPropertyName("set_maximum_value_upon_activation")]
    //public string? SetMaximumValueUponActivation { get; set; }

    //[JsonPropertyName("simple_timeclock")]
    //public string? SimpleTimeclock { get; set; }

    //[JsonPropertyName("snln_options_lot_no_expiration_alert")]
    //public string? SnlnOptionsLotNoExpirationAlert { get; set; }

    //[JsonPropertyName("snln_options_prevent_fc_sn_item_sale_with_zero_qty")]
    //public string? SnlnOptionsPreventFcSnItemSaleWithZeroQty { get; set; }

    //[JsonPropertyName("snln_options_prevent_item_sale_with_expired_lot_no")]
    //public string? SnlnOptionsPreventItemSaleWithExpiredLotNo { get; set; }

    //[JsonPropertyName("so_pm_update_time")]
    //public object SoPmUpdateTime { get; set; }

    //[JsonPropertyName("special_orders_allow_record_sale")]
    //public string? SpecialOrdersAllowRecordSale { get; set; }

    //[JsonPropertyName("struct_zout_auto_open")]
    //public string? StructZoutAutoOpen { get; set; }

    //[JsonPropertyName("struct_zout_blind_close")]
    //public string? StructZoutBlindClose { get; set; }

    //[JsonPropertyName("struct_zout_blind_close_attempts")]
    //public string? StructZoutBlindCloseAttempts { get; set; }

    //[JsonPropertyName("struct_zout_blind_close_variance")]
    //public string? StructZoutBlindCloseVariance { get; set; }

    //[JsonPropertyName("struct_zout_combine_sales_tax_for_vat")]
    //public string? StructZoutCombineSalesTaxForVat { get; set; }

    //[JsonPropertyName("struct_zout_default_sort_by")]
    //public string? StructZoutDefaultSortBy { get; set; }

    //[JsonPropertyName("struct_zout_enable_audits")]
    //public string? StructZoutEnableAudits { get; set; }

    //[JsonPropertyName("struct_zout_end_of_day")]
    //public DateTime? StructZoutEndOfDay { get; set; }

    //[JsonPropertyName("struct_zout_mode")]
    //public string? StructZoutMode { get; set; }

    //[JsonPropertyName("struct_zout_open_close_counts_required")]
    //public string? StructZoutOpenCloseCountsRequired { get; set; }

    //[JsonPropertyName("struct_zout_open_define_default_open_amt_for_each_currency")]
    //public string? StructZoutOpenDefineDefaultOpenAmtForEachCurrency { get; set; }

    //[JsonPropertyName("struct_zout_open_denomination_counts_required")]
    //public string? StructZoutOpenDenominationCountsRequired { get; set; }

    //[JsonPropertyName("struct_zout_print_all_denominations")]
    //public string? StructZoutPrintAllDenominations { get; set; }

    //[JsonPropertyName("struct_zout_register_definition")]
    //public string? StructZoutRegisterDefinition { get; set; }

    //[JsonPropertyName("struct_zout_require_daily_register_closure")]
    //public string? StructZoutRequireDailyRegisterClosure { get; set; }

    //[JsonPropertyName("struct_zout_use_legacy_zout")]
    //public string? StructZoutUseLegacyZout { get; set; }

    //[JsonPropertyName("success_toast_timeout")]
    //public string? SuccessToastTimeout { get; set; }

    //[JsonPropertyName("taxes_apply_customer_tax_areas")]
    //public string? TaxesApplyCustomerTaxAreas { get; set; }

    //[JsonPropertyName("taxes_apply_detax_when")]
    //public string? TaxesApplyDetaxWhen { get; set; }

    //[JsonPropertyName("taxes_general_1st_tax_area_threshold")]
    //public string? TaxesGeneral1stTaxAreaThreshold { get; set; }

    //[JsonPropertyName("taxes_general_2nd_tax_area_threshold")]
    //public string? TaxesGeneral2ndTaxAreaThreshold { get; set; }

    //[JsonPropertyName("taxes_general_allow_tax_rebates")]
    //public string? TaxesGeneralAllowTaxRebates { get; set; }

    //[JsonPropertyName("taxes_general_apply_detax_to_fee")]
    //public string? TaxesGeneralApplyDetaxToFee { get; set; }

    //[JsonPropertyName("taxes_general_apply_detax_to_shipping")]
    //public string? TaxesGeneralApplyDetaxToShipping { get; set; }

    //[JsonPropertyName("taxes_general_apply_detax_to_tax_perc")]
    //public string? TaxesGeneralApplyDetaxToTaxPerc { get; set; }

    //[JsonPropertyName("taxes_general_calc_tax2_from_tax1")]
    //public string? TaxesGeneralCalcTax2FromTax1 { get; set; }

    //[JsonPropertyName("taxes_general_multi_tax_vat")]
    //public string? TaxesGeneralMultiTaxVat { get; set; }

    //[JsonPropertyName("taxes_general_round_ext_tax_amt_up")]
    //public string? TaxesGeneralRoundExtTaxAmtUp { get; set; }

    //[JsonPropertyName("taxes_general_round_tax_amt")]
    //public string? TaxesGeneralRoundTaxAmt { get; set; }

    //[JsonPropertyName("taxes_general_round_tax_method")]
    //public string? TaxesGeneralRoundTaxMethod { get; set; }

    //[JsonPropertyName("taxes_general_source_of_package_tax_info")]
    //public string? TaxesGeneralSourceOfPackageTaxInfo { get; set; }

    //[JsonPropertyName("taxes_general_tax_code_subtotal_calc")]
    //public string? TaxesGeneralTaxCodeSubtotalCalc { get; set; }

    //[JsonPropertyName("taxes_general_tax_method")]
    //public string? TaxesGeneralTaxMethod { get; set; }

    //[JsonPropertyName("taxes_general_tax_rebate_percent")]
    //public string? TaxesGeneralTaxRebatePercent { get; set; }

    //[JsonPropertyName("taxes_general_tax_rebate_threshold")]
    //public string? TaxesGeneralTaxRebateThreshold { get; set; }

    //[JsonPropertyName("taxes_general_tax_use_first_to_calc_second_tax")]
    //public string? TaxesGeneralTaxUseFirstToCalcSecondTax { get; set; }

    //[JsonPropertyName("taxes_general_use_pwt_for_second_tax")]
    //public string? TaxesGeneralUsePwtForSecondTax { get; set; }

    //[JsonPropertyName("themes_and_layouts_default_pos_layout")]
    //public string? ThemesAndLayoutsDefaultPosLayout { get; set; }

    //[JsonPropertyName("themes_and_layouts_default_theme")]
    //public object ThemesAndLayoutsDefaultTheme { get; set; }

    //[JsonPropertyName("themes_and_layouts_rp_button_image")]
    //public string? ThemesAndLayoutsRpButtonImage { get; set; }

    //[JsonPropertyName("themes_and_layouts_view_path")]
    //public string? ThemesAndLayoutsViewPath { get; set; }

    //[JsonPropertyName("touch_menu_default_item_button_appearance")]
    //public string? TouchMenuDefaultItemButtonAppearance { get; set; }

    //[JsonPropertyName("touch_menu_default_main_menu_button_label")]
    //public string? TouchMenuDefaultMainMenuButtonLabel { get; set; }

    //[JsonPropertyName("touch_menu_default_menu_sid")]
    //public string? TouchMenuDefaultMenuSid { get; set; }

    //[JsonPropertyName("touch_menu_default_navigation_button_appearance")]
    //public string? TouchMenuDefaultNavigationButtonAppearance { get; set; }

    //[JsonPropertyName("touch_menu_default_next_page_button_label")]
    //public string? TouchMenuDefaultNextPageButtonLabel { get; set; }

    //[JsonPropertyName("touch_menu_default_previous_menu_button_label")]
    //public string? TouchMenuDefaultPreviousMenuButtonLabel { get; set; }

    //[JsonPropertyName("touch_menu_default_previous_page_button_label")]
    //public string? TouchMenuDefaultPreviousPageButtonLabel { get; set; }

    //[JsonPropertyName("touch_menu_label_field")]
    //public string? TouchMenuLabelField { get; set; }

    //[JsonPropertyName("touch_menu_page_size")]
    //public string? TouchMenuPageSize { get; set; }

    //[JsonPropertyName("transactions_deposits_min_customer_order_perc")]
    //public string? TransactionsDepositsMinCustomerOrderPerc { get; set; }

    //[JsonPropertyName("transactions_deposits_min_customer_order_required")]
    //public string? TransactionsDepositsMinCustomerOrderRequired { get; set; }

    //[JsonPropertyName("transactions_deposits_min_layaway_order_perc")]
    //public string? TransactionsDepositsMinLayawayOrderPerc { get; set; }

    //[JsonPropertyName("transactions_deposits_min_layaway_order_required")]
    //public string? TransactionsDepositsMinLayawayOrderRequired { get; set; }

    //[JsonPropertyName("transactions_deposits_min_special_order_perc")]
    //public string? TransactionsDepositsMinSpecialOrderPerc { get; set; }

    //[JsonPropertyName("transactions_deposits_min_special_order_required")]
    //public string? TransactionsDepositsMinSpecialOrderRequired { get; set; }

    //[JsonPropertyName("transactions_general_advanced_item_lookup_by")]
    //public string? TransactionsGeneralAdvancedItemLookupBy { get; set; }

    //[JsonPropertyName("transactions_general_after_trans_update_goto")]
    //public string? TransactionsGeneralAfterTransUpdateGoto { get; set; }

    //[JsonPropertyName("transactions_general_alert_cashier_when_price_less_than_cost")]
    //public string? TransactionsGeneralAlertCashierWhenPriceLessThanCost { get; set; }

    //[JsonPropertyName("transactions_general_allow_store_credit_tender")]
    //public string? TransactionsGeneralAllowStoreCreditTender { get; set; }

    //[JsonPropertyName("transactions_general_change_window_cash")]
    //public string? TransactionsGeneralChangeWindowCash { get; set; }

    //[JsonPropertyName("transactions_general_change_window_central_credit")]
    //public string? TransactionsGeneralChangeWindowCentralCredit { get; set; }

    //[JsonPropertyName("transactions_general_change_window_central_gift_card")]
    //public string? TransactionsGeneralChangeWindowCentralGiftCard { get; set; }

    //[JsonPropertyName("transactions_general_change_window_central_gift_cert")]
    //public string? TransactionsGeneralChangeWindowCentralGiftCert { get; set; }

    //[JsonPropertyName("transactions_general_change_window_central_loyalty")]
    //public string? TransactionsGeneralChangeWindowCentralLoyalty { get; set; }

    //[JsonPropertyName("transactions_general_change_window_charge")]
    //public string? TransactionsGeneralChangeWindowCharge { get; set; }

    //[JsonPropertyName("transactions_general_change_window_check")]
    //public string? TransactionsGeneralChangeWindowCheck { get; set; }

    //[JsonPropertyName("transactions_general_change_window_cod")]
    //public string? TransactionsGeneralChangeWindowCod { get; set; }

    //[JsonPropertyName("transactions_general_change_window_credit")]
    //public string? TransactionsGeneralChangeWindowCredit { get; set; }

    //[JsonPropertyName("transactions_general_change_window_customtender1")]
    //public string? TransactionsGeneralChangeWindowCustomtender1 { get; set; }

    //[JsonPropertyName("transactions_general_change_window_customtender10")]
    //public string? TransactionsGeneralChangeWindowCustomtender10 { get; set; }

    //[JsonPropertyName("transactions_general_change_window_customtender2")]
    //public string? TransactionsGeneralChangeWindowCustomtender2 { get; set; }

    //[JsonPropertyName("transactions_general_change_window_customtender3")]
    //public string? TransactionsGeneralChangeWindowCustomtender3 { get; set; }

    //[JsonPropertyName("transactions_general_change_window_customtender4")]
    //public string? TransactionsGeneralChangeWindowCustomtender4 { get; set; }

    //[JsonPropertyName("transactions_general_change_window_customtender5")]
    //public string? TransactionsGeneralChangeWindowCustomtender5 { get; set; }

    //[JsonPropertyName("transactions_general_change_window_customtender6")]
    //public string? TransactionsGeneralChangeWindowCustomtender6 { get; set; }

    //[JsonPropertyName("transactions_general_change_window_customtender7")]
    //public string? TransactionsGeneralChangeWindowCustomtender7 { get; set; }

    //[JsonPropertyName("transactions_general_change_window_customtender8")]
    //public string? TransactionsGeneralChangeWindowCustomtender8 { get; set; }

    //[JsonPropertyName("transactions_general_change_window_customtender9")]
    //public string? TransactionsGeneralChangeWindowCustomtender9 { get; set; }

    //[JsonPropertyName("transactions_general_change_window_debit")]
    //public string? TransactionsGeneralChangeWindowDebit { get; set; }

    //[JsonPropertyName("transactions_general_change_window_foreign_currency")]
    //public string? TransactionsGeneralChangeWindowForeignCurrency { get; set; }

    //[JsonPropertyName("transactions_general_change_window_gift")]
    //public string? TransactionsGeneralChangeWindowGift { get; set; }

    //[JsonPropertyName("transactions_general_change_window_gift_cert")]
    //public string? TransactionsGeneralChangeWindowGiftCert { get; set; }

    //[JsonPropertyName("transactions_general_change_window_payment")]
    //public string? TransactionsGeneralChangeWindowPayment { get; set; }

    //[JsonPropertyName("transactions_general_change_window_store_credit")]
    //public string? TransactionsGeneralChangeWindowStoreCredit { get; set; }

    //[JsonPropertyName("transactions_general_default_item_type")]
    //public string? TransactionsGeneralDefaultItemType { get; set; }

    //[JsonPropertyName("transactions_general_default_order_type")]
    //public string? TransactionsGeneralDefaultOrderType { get; set; }

    //[JsonPropertyName("transactions_general_enable_special_orders")]
    //public string? TransactionsGeneralEnableSpecialOrders { get; set; }

    //[JsonPropertyName("transactions_general_force_logout_after_transaction")]
    //public string? TransactionsGeneralForceLogoutAfterTransaction { get; set; }

    //[JsonPropertyName("transactions_general_name_of_cod_field")]
    //public string? TransactionsGeneralNameOfCodField { get; set; }

    //[JsonPropertyName("transactions_general_require_ar_customer_for_fees")]
    //public string? TransactionsGeneralRequireArCustomerForFees { get; set; }

    //[JsonPropertyName("transactions_general_require_customer_for_manual_discount")]
    //public string? TransactionsGeneralRequireCustomerForManualDiscount { get; set; }

    //[JsonPropertyName("transactions_general_require_customer_returns")]
    //public string? TransactionsGeneralRequireCustomerReturns { get; set; }

    //[JsonPropertyName("transactions_general_require_customer_sales")]
    //public string? TransactionsGeneralRequireCustomerSales { get; set; }

    //[JsonPropertyName("transactions_general_restrict_order_item_rows_to_single_quantities")]
    //public string? TransactionsGeneralRestrictOrderItemRowsToSingleQuantities { get; set; }

    //[JsonPropertyName("transactions_general_restrict_return_tenders_to_original_sale_tenders")]
    //public string? TransactionsGeneralRestrictReturnTendersToOriginalSaleTenders { get; set; }

    //[JsonPropertyName("transactions_orders_customer_minimum_deposit")]
    //public string? TransactionsOrdersCustomerMinimumDeposit { get; set; }

    //[JsonPropertyName("transactions_orders_customer_minimum_deposit_required")]
    //public string? TransactionsOrdersCustomerMinimumDepositRequired { get; set; }

    //[JsonPropertyName("transactions_orders_enable_customer_orders")]
    //public string? TransactionsOrdersEnableCustomerOrders { get; set; }

    //[JsonPropertyName("transactions_orders_enable_layaway_orders")]
    //public string? TransactionsOrdersEnableLayawayOrders { get; set; }

    //[JsonPropertyName("transactions_orders_layaway_minimum_deposit")]
    //public string? TransactionsOrdersLayawayMinimumDeposit { get; set; }

    //[JsonPropertyName("transactions_orders_layaway_minimum_deposit_required")]
    //public string? TransactionsOrdersLayawayMinimumDepositRequired { get; set; }

    //[JsonPropertyName("transactions_pos_flags_default_value_pos_flag_menu1")]
    //public string? TransactionsPosFlagsDefaultValuePosFlagMenu1 { get; set; }

    //[JsonPropertyName("transactions_pos_flags_default_value_pos_flag_menu2")]
    //public string? TransactionsPosFlagsDefaultValuePosFlagMenu2 { get; set; }

    //[JsonPropertyName("transactions_pos_flags_default_value_pos_flag_menu3")]
    //public string? TransactionsPosFlagsDefaultValuePosFlagMenu3 { get; set; }

    //[JsonPropertyName("transactions_pos_flags_menu_one_required")]
    //public string? TransactionsPosFlagsMenuOneRequired { get; set; }

    //[JsonPropertyName("transactions_pos_flags_menu_three_required")]
    //public string? TransactionsPosFlagsMenuThreeRequired { get; set; }

    //[JsonPropertyName("transactions_pos_flags_menu_two_required")]
    //public string? TransactionsPosFlagsMenuTwoRequired { get; set; }

    //[JsonPropertyName("transactions_promos_apply_automatically_or_manually")]
    //public string? TransactionsPromosApplyAutomaticallyOrManually { get; set; }

    //[JsonPropertyName("transactions_promos_apply_before_tendering")]
    //public string? TransactionsPromosApplyBeforeTendering { get; set; }

    //[JsonPropertyName("transactions_promos_enable")]
    //public string? TransactionsPromosEnable { get; set; }

    //[JsonPropertyName("transactions_promos_field_storing_manual_disc")]
    //public object TransactionsPromosFieldStoringManualDisc { get; set; }

    //[JsonPropertyName("transactions_promos_new_or_legacy_promos")]
    //public string? TransactionsPromosNewOrLegacyPromos { get; set; }

    //[JsonPropertyName("transactions_promos_unique_names")]
    //public string? TransactionsPromosUniqueNames { get; set; }

    //[JsonPropertyName("transactions_promos_use_manually_discounted_items")]
    //public string? TransactionsPromosUseManuallyDiscountedItems { get; set; }

    //[JsonPropertyName("transactions_promos_use_predefined_discount_reasons")]
    //public string? TransactionsPromosUsePredefinedDiscountReasons { get; set; }

    //[JsonPropertyName("transactions_returns_default_item_return_reason")]
    //public string? TransactionsReturnsDefaultItemReturnReason { get; set; }

    //[JsonPropertyName("transactions_returns_require_reason_on_item_returns")]
    //public string? TransactionsReturnsRequireReasonOnItemReturns { get; set; }

    //[JsonPropertyName("transactions_seperate_for_sales_and_orders")]
    //public string? TransactionsSeperateForSalesAndOrders { get; set; }

    //[JsonPropertyName("transactions_tenders_check_available_charge_balance")]
    //public string? TransactionsTendersCheckAvailableChargeBalance { get; set; }

    //[JsonPropertyName("transfer_slip_fee_types")]
    //public object TransferSlipFeeTypes { get; set; }

    //[JsonPropertyName("transfers_after_slip_updated_go_to")]
    //public string? TransfersAfterSlipUpdatedGoTo { get; set; }

    //[JsonPropertyName("transfers_availability_check")]
    //public string? TransfersAvailabilityCheck { get; set; }

    //[JsonPropertyName("transfers_general_consolidate_like_items")]
    //public string? TransfersGeneralConsolidateLikeItems { get; set; }

    //[JsonPropertyName("transfers_general_require_slips_reference_to")]
    //public string? TransfersGeneralRequireSlipsReferenceTo { get; set; }

    //[JsonPropertyName("transfers_require_comment_on_slip")]
    //public string? TransfersRequireCommentOnSlip { get; set; }

    //[JsonPropertyName("ts_default_resolution_method")]
    //public string? TsDefaultResolutionMethod { get; set; }

    //[JsonPropertyName("ts_generate_doc_upon_update")]
    //public string? TsGenerateDocUponUpdate { get; set; }

    //[JsonPropertyName("ts_resolution_rules")]
    //public string? TsResolutionRules { get; set; }

    //[JsonPropertyName("ts_verify_transfers_upon_voucher_update")]
    //public string? TsVerifyTransfersUponVoucherUpdate { get; set; }

    //[JsonPropertyName("update_order_cost_when_making_vouchers")]
    //public string? UpdateOrderCostWhenMakingVouchers { get; set; }

    //[JsonPropertyName("use_single_sequence_for_all_order_types")]
    //public string? UseSingleSequenceForAllOrderTypes { get; set; }

    //[JsonPropertyName("use_single_sequence_for_return_and_sales")]
    //public string? UseSingleSequenceForReturnAndSales { get; set; }

    //[JsonPropertyName("vouchers_enable_committed_sales_order_alerts")]
    //public string? VouchersEnableCommittedSalesOrderAlerts { get; set; }

    //[JsonPropertyName("vouchers_enable_vendor_invoice")]
    //public string? VouchersEnableVendorInvoice { get; set; }

    //[JsonPropertyName("warning_toast_timeout")]
    //public string? WarningToastTimeout { get; set; }

    //[JsonPropertyName("workstation_types")]
    //public string? WorkstationTypes { get; set; }

    //[JsonPropertyName("xzout_print_itemized_central_credit_tenders")]
    //public string? XzoutPrintItemizedCentralCreditTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_central_gift_card_tenders")]
    //public string? XzoutPrintItemizedCentralGiftCardTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_central_gift_certificate_tenders")]
    //public string? XzoutPrintItemizedCentralGiftCertificateTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_charge_tenders")]
    //public string? XzoutPrintItemizedChargeTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_check_tenders")]
    //public string? XzoutPrintItemizedCheckTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_cod_tenders")]
    //public string? XzoutPrintItemizedCodTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_credit_card_tenders")]
    //public string? XzoutPrintItemizedCreditCardTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customer_loyalty_tenders")]
    //public string? XzoutPrintItemizedCustomerLoyaltyTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customtender1")]
    //public string? XzoutPrintItemizedCustomtender1 { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customtender10")]
    //public string? XzoutPrintItemizedCustomtender10 { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customtender2")]
    //public string? XzoutPrintItemizedCustomtender2 { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customtender3")]
    //public string? XzoutPrintItemizedCustomtender3 { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customtender4")]
    //public string? XzoutPrintItemizedCustomtender4 { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customtender5")]
    //public string? XzoutPrintItemizedCustomtender5 { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customtender6")]
    //public string? XzoutPrintItemizedCustomtender6 { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customtender7")]
    //public string? XzoutPrintItemizedCustomtender7 { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customtender8")]
    //public string? XzoutPrintItemizedCustomtender8 { get; set; }

    //[JsonPropertyName("xzout_print_itemized_customtender9")]
    //public string? XzoutPrintItemizedCustomtender9 { get; set; }

    //[JsonPropertyName("xzout_print_itemized_debit_card_tenders")]
    //public string? XzoutPrintItemizedDebitCardTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_deposit_tenders")]
    //public string? XzoutPrintItemizedDepositTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_foreign_currency_check_tenders")]
    //public string? XzoutPrintItemizedForeignCurrencyCheckTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_gift_card_tenders")]
    //public string? XzoutPrintItemizedGiftCardTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_gift_certificate_tenders")]
    //public string? XzoutPrintItemizedGiftCertificateTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_payments_tenders")]
    //public string? XzoutPrintItemizedPaymentsTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_store_credit_tenders")]
    //public string? XzoutPrintItemizedStoreCreditTenders { get; set; }

    //[JsonPropertyName("xzout_print_itemized_traveler_check_tenders")]
    //public string? XzoutPrintItemizedTravelerCheckTenders { get; set; }

    //[JsonPropertyName("zout_leave_define_each_currency_amount")]
    //public object? ZoutLeaveDefineEachCurrencyAmount { get; set; }

    //[JsonPropertyName("zout_maximum_balance")]
    //public string? ZoutMaximumBalance { get; set; }

    //[JsonPropertyName("zout_maximum_balance_enabled")]
    //public string? ZoutMaximumBalanceEnabled { get; set; }

    //[JsonPropertyName("zout_open_denomination_counts_required")]
    //public string? ZoutOpenDenominationCountsRequired { get; set; }

    //[JsonPropertyName("zout_require_finalization_before_reopen")]
    //public string? ZoutRequireFinalizationBeforeReopen { get; set; }

    //[JsonPropertyName("zout_use_sequencing")]
    //public string? ZoutUseSequencing { get; set; }
}

public class AlterSessionResponse
{
    [JsonPropertyName("sid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Sid { get; set; }

    [JsonPropertyName("createdby")]
    public string? Createdby { get; set; }

    [JsonPropertyName("createddatetime")]
    public DateTime? Createddatetime { get; set; }

    [JsonPropertyName("modifiedby")]
    public string? Modifiedby { get; set; }

    [JsonPropertyName("modifieddatetime")]
    public DateTime? Modifieddatetime { get; set; }

    [JsonPropertyName("controllersid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Controllersid { get; set; }

    [JsonPropertyName("originapplication")]
    public string? Originapplication { get; set; }

    [JsonPropertyName("postdate")]
    public DateTime? Postdate { get; set; }

    [JsonPropertyName("rowversion")]
    public int? Rowversion { get; set; }

    [JsonPropertyName("tenantsid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Tenantsid { get; set; }

    [JsonPropertyName("sessionstatus")]
    public int? Sessionstatus { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [JsonPropertyName("employeesid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Employeesid { get; set; }

    [JsonPropertyName("employeename")]
    public string? Employeename { get; set; }

    [JsonPropertyName("employeeactive")]
    public bool? Employeeactive { get; set; }

    [JsonPropertyName("employeeissysadmin")]
    public bool? Employeeissysadmin { get; set; }

    [JsonPropertyName("workstationid")]
    public string? Workstationid { get; set; }

    [JsonPropertyName("databasetype")]
    public string? Databasetype { get; set; }

    [JsonPropertyName("seated")]
    public bool? Seated { get; set; }

    [JsonPropertyName("seatsid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Seatsid { get; set; }

    [JsonPropertyName("seatedapp")]
    public string? Seatedapp { get; set; }

    [JsonPropertyName("token")]
    public string? Token { get; set; }

    [JsonPropertyName("nonce")]
    public string? Nonce { get; set; }

    [JsonPropertyName("internal")]
    public bool? Internal { get; set; }

    [JsonPropertyName("lasttransaction")]
    public DateTime? Lasttransaction { get; set; }

    [JsonPropertyName("subsidiarysid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Subsidiarysid { get; set; }

    [JsonPropertyName("storesid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Storesid { get; set; }

    [JsonPropertyName("seasonsid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Seasonsid { get; set; }

    [JsonPropertyName("regionsid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Regionsid { get; set; }

    [JsonPropertyName("districtsid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Districtsid { get; set; }

    [JsonPropertyName("workstationtype")]
    public int? Workstationtype { get; set; }

    [JsonPropertyName("workstation")]
    public string? Workstation { get; set; }

    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    [JsonPropertyName("storeactive")]
    public bool? Storeactive { get; set; }

    [JsonPropertyName("departmentname")]
    public object? Departmentname { get; set; }

    [JsonPropertyName("homeurl")]
    public object? Homeurl { get; set; }

    [JsonPropertyName("xforwardedfor")]
    public object? Xforwardedfor { get; set; }

    [JsonPropertyName("serveraddress")]
    public string? Serveraddress { get; set; }

    [JsonPropertyName("imageserveraddress")]
    public string? Imageserveraddress { get; set; }

    [JsonPropertyName("oldsbssid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Oldsbssid { get; set; }

    [JsonPropertyName("oldstoresid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Oldstoresid { get; set; }

    [JsonPropertyName("servertimezone")]
    public int? Servertimezone { get; set; }

    [JsonPropertyName("pricelevelsid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Pricelevelsid { get; set; }

    [JsonPropertyName("hisecsbssid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Hisecsbssid { get; set; }

    [JsonPropertyName("hisecemplsid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Hisecemplsid { get; set; }

    [JsonPropertyName("basecurrencycodealpha")]
    public string? Basecurrencycodealpha { get; set; }

    [JsonPropertyName("basecurrencysymbol")]
    public string? Basecurrencysymbol { get; set; }

    [JsonPropertyName("controllernumber")]
    public int? Controllernumber { get; set; }

    [JsonPropertyName("workstationnumber")]
    public int? Workstationnumber { get; set; }

    [JsonPropertyName("subsidiarynumber")]
    public int? Subsidiarynumber { get; set; }

    [JsonPropertyName("storenumber")]
    public int? Storenumber { get; set; }

    [JsonPropertyName("storecode")]
    public string? Storecode { get; set; }

    [JsonPropertyName("subsidiaryname")]
    public string? Subsidiaryname { get; set; }

    [JsonPropertyName("storename")]
    public string? Storename { get; set; }

    [JsonPropertyName("languagesid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Languagesid { get; set; }

    [JsonPropertyName("ispoa")]
    public bool? Ispoa { get; set; }

    [JsonPropertyName("isstore")]
    public bool? Isstore { get; set; }

    [JsonPropertyName("isstandalone")]
    public bool? Isstandalone { get; set; }

    [JsonPropertyName("tillsid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Tillsid { get; set; }

    [JsonPropertyName("drawernumber")]
    public int? Drawernumber { get; set; }

    [JsonPropertyName("employeemaxdiscperc")]
    public decimal? Employeemaxdiscperc { get; set; }

    [JsonPropertyName("countrycode")]
    public object? Countrycode { get; set; }

    [JsonPropertyName("rpproductcode")]
    public string? Rpproductcode { get; set; }

    [JsonPropertyName("opendrawereventsid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Opendrawereventsid { get; set; }

    [JsonPropertyName("basecurrencysid")]
    public string? Basecurrencysid { get; set; }

    [JsonPropertyName("countrysid")]
    public string? Countrysid { get; set; }

    [JsonPropertyName("statuserrorcode")]
    public int? Statuserrorcode { get; set; }

    [JsonPropertyName("link")]
    public string? Link { get; set; }

    [JsonPropertyName("preferences")]
    public Preferences? Preferences { get; set; }

    [JsonPropertyName("permissions")]
    public Permissions? Permissions { get; set; }

    [JsonPropertyName("registersid")]
    [JsonConverter(typeof(SidConverter))]
    public long? Registersid { get; set; }

    [JsonPropertyName("registerstate")]
    public int? Registerstate { get; set; }

    [JsonPropertyName("cacheseq")]
    public int? Cacheseq { get; set; }

    [JsonPropertyName("licenseinfo")]
    public Licenseinfo? Licenseinfo { get; set; }
}

