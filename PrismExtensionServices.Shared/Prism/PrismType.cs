using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public enum PrismType
{
    None = 0,
    InventoryItem = 10,  //  1
    Customer = 20,       //  2
    Supplier = 30,       //  3
    Slip = 40,           //  4
    Asn = 50,            //  5
    Voucher = 60,        //  6
    Sale = 70,           //  7
    Deposit = 80,        //  7 *New
    Return = 90,         //  7 *New
    SalesOrder = 100,     //  8
    PurchaseOrder = 110, //  9
    TransferOrder = 120, // 10
    Tender = 130,        // 11
    Layaway = 140,       // 12
    Adjustment = 150     // 13
}
