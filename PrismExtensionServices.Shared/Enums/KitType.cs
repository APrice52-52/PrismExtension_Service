namespace PrismExtensionServices.Shared;

/// <summary>
/// invn_sbs_item.kit_type (DB field; distinct from the API-level KitFlag enum)
/// </summary>
public enum KitType
{
    NoEntry              = 0,
    Kit                  = 1,
    Package              = 2,
    GiftCardStoredValue  = 3,
    GiftCardPrePaid      = 4,
    GiftCertificate      = 5,
    Fee                  = 6,
    GiftCardCentral      = 7,
}
