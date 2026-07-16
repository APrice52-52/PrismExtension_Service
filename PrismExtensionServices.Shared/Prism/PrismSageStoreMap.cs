#nullable enable

using System.ComponentModel;

#if (!NETFR)
namespace PrismExtensionServices.Shared.Prism;
#else
namespace SoCancelFeePlugin
{
#endif


public struct PrismSageStoreMap
{
    [DisplayName("Store Sid")]
    public long StoreSid { get; set; }
    [DisplayName("Sage Warehouse")]
    public string? SageWarehouse { get; set; }
    [DisplayName("Default Sage Customer Code")]
    public string? SageDefaultCustomerCode { get; set; }
    [DisplayName("Default Sage Sales Rep Code")]
    public string? SageDefaultSalesRepCode { get; set; }
    [DisplayName("Sage SalesOrder Prefix")]
    public string? SageSalesOrderPrefix { get; set; }
    [DisplayName("Sage Invoice Prefix")]
    public string? SageInvoicePrefix { get; set; }
    [DisplayName("Sage CreditNote Prefix")]
    public string? SageCreditNotePrefix { get; set; }
    [DisplayName("Sage Adjustment Prefix")]
    public string? SageAdjustmentPrefix { get; set; }
    [DisplayName("Sage Transfer Prefix")]
    public string? SageTransferPrefix { get; set; }
    [DisplayName("Sage Vendor GRV Prefix")]
    public string? SageVendorGrvPrefix { get; set; }

    [DisplayName("Sage Refund Prefix")]
    public string? SageRefundPrefix { get; set; }


    [DisplayName("Sage TenderCode: Cash Take")]
    public string? SageTenderCodeCashTake { get; set; }
    [DisplayName("Sage TenderCode: Cash Give")]
    public string? SageTenderCodeCashGive { get; set; }


    [DisplayName("Sage TenderCode: Check Take")]
    public string? SageTenderCodeCheckTake { get; set; }
    [DisplayName("Sage TenderCode: Check Give")]
    public string? SageTenderCodeCheckGive { get; set; }


    [DisplayName("Sage TenderCode: Credit Card Take")]
    public string? SageTenderCodeCreditCardTake { get; set; }
    [DisplayName("Sage TenderCode: Credit Card Give")]
    public string? SageTenderCodeCreditCardGive { get; set; }


    [DisplayName("Sage TenderCode: Debit Card Take")]
    public string? SageTenderCodeDebitCardTake { get; set; }
    [DisplayName("Sage TenderCode: Debit Card Give")]
    public string? SageTenderCodeDebitCardGive { get; set; }


    [DisplayName("Sage TenderCode: C.O.D. Take")]
    public string? SageTenderCodeCodTake { get; set; }
    [DisplayName("Sage TenderCode: C.O.D. Give")]
    public string? SageTenderCodeCodGive { get; set; }


    [DisplayName("Sage TenderCode: Foreign Currency Take")]
    public string? SageTenderCodeForeignCurrencyTake { get; set; }
    [DisplayName("Sage TenderCode: Foreign Currency Give")]
    public string? SageTenderCodeForeignCurrencyGive { get; set; }


    [DisplayName("Sage TenderCode: Gift Card Take")]
    public string? SageTenderCodeGiftCardTake { get; set; }
    [DisplayName("Sage TenderCode: Gift Card Give")]
    public string? SageTenderCodeGiftCardGive { get; set; }


    [DisplayName("Sage TenderCode: Gift Certificate Take")]
    public string? SageTenderCodeGiftCertificateTake { get; set; }
    [DisplayName("Sage TenderCode: Gift Certificate Give")]
    public string? SageTenderCodeGiftCertificateGive { get; set; }


    [DisplayName("Sage TenderCode: Custom01 Take")]
    public string? SageTenderCodeCustom01Take { get; set; }
    [DisplayName("Sage TenderCode: Custom01 Give")]
    public string? SageTenderCodeCustom01Give { get; set; }


    [DisplayName("Sage TenderCode: Custom02 Take")]
    public string? SageTenderCodeCustom02Take { get; set; }
    [DisplayName("Sage TenderCode: Custom02 Give")]
    public string? SageTenderCodeCustom02Give { get; set; }


    [DisplayName("Sage TenderCode: Custom03 Take")]
    public string? SageTenderCodeCustom03Take { get; set; }
    [DisplayName("Sage TenderCode: Custom03 Give")]
    public string? SageTenderCodeCustom03Give { get; set; }


    [DisplayName("Sage TenderCode: Custom04 Take")]
    public string? SageTenderCodeCustom04Take { get; set; }
    [DisplayName("Sage TenderCode: Custom04 Give")]
    public string? SageTenderCodeCustom04Give { get; set; }


    [DisplayName("Sage TenderCode: Custom05 Take")]
    public string? SageTenderCodeCustom05Take { get; set; }
    [DisplayName("Sage TenderCode: Custom05 Give")]
    public string? SageTenderCodeCustom05Give { get; set; }


    [DisplayName("Sage TenderCode: Custom06 Take")]
    public string? SageTenderCodeCustom06Take { get; set; }
    [DisplayName("Sage TenderCode: Custom06 Give")]
    public string? SageTenderCodeCustom06Give { get; set; }


    [DisplayName("Sage TenderCode: Custom07 Take")]
    public string? SageTenderCodeCustom07Take { get; set; }
    [DisplayName("Sage TenderCode: Custom07 Give")]
    public string? SageTenderCodeCustom07Give { get; set; }


    [DisplayName("Sage TenderCode: Custom08 Take")]
    public string? SageTenderCodeCustom08Take { get; set; }
    [DisplayName("Sage TenderCode: Custom08 Give")]
    public string? SageTenderCodeCustom08Give { get; set; }


    [DisplayName("Sage TenderCode: Custom09 Take")]
    public string? SageTenderCodeCustom09Take { get; set; }
    [DisplayName("Sage TenderCode: Custom09 Give")]
    public string? SageTenderCodeCustom09Give { get; set; }


    [DisplayName("Sage TenderCode: Custom10 Take")]
    public string? SageTenderCodeCustom10Take { get; set; }
    [DisplayName("Sage TenderCode: Custom10 Give")]
    public string? SageTenderCodeCustom10Give { get; set; }

    //[DisplayName("Sage Default Rep Code")]
    //public string? DefaultRepCode { get; set; }

    [DisplayName("Sage Default Agent Name")]
    public string? DefaultAgentName { get; set; }

    public bool IsConfigured
    {
        get
        {
            return !(
                string.IsNullOrWhiteSpace(this.DefaultAgentName)
                || string.IsNullOrWhiteSpace(this.SageAdjustmentPrefix)
                || string.IsNullOrWhiteSpace(this.SageCreditNotePrefix)
                || string.IsNullOrWhiteSpace(this.SageDefaultCustomerCode)
                || string.IsNullOrWhiteSpace(this.SageDefaultSalesRepCode)
                || string.IsNullOrWhiteSpace(this.SageInvoicePrefix)
                || string.IsNullOrWhiteSpace(this.SageRefundPrefix)
                || string.IsNullOrWhiteSpace(this.SageSalesOrderPrefix)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCashGive)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCashTake)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCheckGive)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCheckTake)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCodGive)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCodTake)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCreditCardGive)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCreditCardTake)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom01Give)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom01Take)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom02Give)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom02Take)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom03Give)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom03Take)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom04Give)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom04Take)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom05Give)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom05Take)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom06Give)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom06Take)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom07Give)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom07Take)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom08Give)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom08Take)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom09Give)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom09Take)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom10Give)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeCustom10Take)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeDebitCardGive)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeDebitCardTake)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeForeignCurrencyGive)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeForeignCurrencyTake)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeGiftCardGive)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeGiftCardTake)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeGiftCertificateGive)
                || string.IsNullOrWhiteSpace(this.SageTenderCodeGiftCertificateTake)
                || string.IsNullOrWhiteSpace(this.SageTransferPrefix)
                || string.IsNullOrWhiteSpace(this.SageVendorGrvPrefix)
                || string.IsNullOrWhiteSpace(this.SageWarehouse)
                || this.StoreSid == 0
                );
        }
    }

    public override string ToString()
    {
        return $"{SageWarehouse}";
    }
}
#if (NETFR)
}
#endif
