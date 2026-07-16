namespace PrismExtensionServices.Shared;

/// <summary>
/// document.status / voucher.status / slip.status / adjustment.status
/// </summary>
public enum DocumentStatus
{
    None      = 0,
    Changed   = 1,
    Cancelled = 2,
    Normal    = 3,
    Completed = 4,
}
