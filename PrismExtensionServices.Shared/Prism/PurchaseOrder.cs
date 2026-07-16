using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class PurchaseOrder
{
    public string? SupplierAccount { get; set; }
    public string? Warehouse { get; set; }
    public string? PoNumber { get; set; }
    public string? GrvNumber { get; set; }
    public string? Message1 { get; set; }
    public string? Message2 { get; set; }
    public string? Message3 { get; set; }
    public List<VoucherItem> Items { get; set; } = new();
}
