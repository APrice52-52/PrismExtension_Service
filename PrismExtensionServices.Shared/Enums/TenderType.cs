namespace PrismExtensionServices.Shared;

/// <summary>
/// tender.tender_type / document.tender_type
/// Values 0–18 from document.tender_type column comment.
/// Values 19–28 (Custom01–Custom10) confirmed from live tender table data.
/// </summary>
public enum TenderType
{
    Cash                   = 0,
    Check                  = 1,
    CreditCard             = 2,
    COD                    = 3,
    Charge                 = 4,
    StoreCredit            = 5,
    Split                  = 6,
    Deposit                = 7,
    Payments               = 8,
    GiftCertificate        = 9,
    GiftCard               = 10,
    DebitCard              = 11,
    ForeignCurrency        = 12,
    TravelerCheck          = 13,
    ForeignCheck           = 14,
    CentralGiftCard        = 15,
    CentralGiftCertificate = 16,
    CentralCustomerCredit  = 17,
    CentralCustomerLoyalty = 18,
    Custom01               = 19,
    Custom02               = 20,
    Custom03               = 21,
    Custom04               = 22,
    Custom05               = 23,
    Custom06               = 24,
    Custom07               = 25,
    Custom08               = 26,
    Custom09               = 27,
    Custom10               = 28,
}
