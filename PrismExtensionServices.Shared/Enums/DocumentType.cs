namespace PrismExtensionServices.Shared;

/// <summary>
/// Cross-reference document type code used in fields such as
/// adjustment.creating_doc_type (7 and 8 confirmed in DB).
/// </summary>
public enum DocumentType
{
    Sale          = 1,
    Return        = 2,
    Exchange      = 3,
    SalesOrder    = 4,
    PurchaseOrder = 5,
    TransferOrder = 6,
    Adjustment    = 7,
    Voucher       = 8,
}
