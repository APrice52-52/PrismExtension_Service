namespace PrismExtensionServices.Shared;

/// <summary>
/// Built-in fee type codes used in document.fee_type1..5 / document_fee_type.fee_type.
/// Negative values are reserved by Prism; positive slots (0–9) are configurable.
/// </summary>
public enum SystemFeeType
{
    AutoAdjustment        = -8,
    CreditCardConversion  = -7,
    DisbursementPaidIn    = -6,
    DisbursementPaidOut   = -5,
    CashDrop              = -4,
    StoreCreditAdjustment = -3,
    SalesOrderDeposit     = -2,
}
