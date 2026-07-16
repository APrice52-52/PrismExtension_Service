using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
public class DocumentItem : InventoryItem
{

    public enum DocumentItemType
    {
        Sale = 1,
        Return = -1,
        NoOp = 0
    }


    public long DocLineSid { get; set; }
    public decimal Qty { get; set; }
    public DocumentItemType ItemType { get; set; }
    public decimal Pwt { get; set; }
    public decimal Tax { get; set; }
    public decimal OriginalPwt { get; set; }
    public decimal OriginalTax { get; set; }

    public decimal Cost { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Notes { get; set; }

    [JsonIgnore]
    public decimal OriginalPriceExcl 
        => OriginalPwt - Tax;

    [JsonIgnore]
    public decimal PriceExcl
        => Pwt - Tax;

    [JsonIgnore]
    public decimal ExtPwt
        => Pwt * Qty * (int)ItemType;

    [JsonIgnore]
    public decimal ExtPriceExcl
        => (Pwt - Tax) * Qty * (int)ItemType;

    [JsonIgnore]
    public decimal ExtOriginalPwt
        => OriginalPwt * Qty * (int)ItemType;

    [JsonIgnore]
    public decimal ExtOriginalPriceExcl
        => (OriginalPwt - OriginalTax) * Qty * (int)ItemType;

    [JsonIgnore]
    public decimal ExtCost
        => Cost * Qty * (int)ItemType;

    [JsonIgnore]
    public decimal DiscountIncl
        => OriginalPwt - Pwt;

    [JsonIgnore]
    public decimal DiscountExcl
        => OriginalPriceExcl - PriceExcl;

    [JsonIgnore]
    public decimal ExtDiscountIncl
        => (OriginalPwt - Pwt) * Qty * (int)ItemType;

    [JsonIgnore]
    public decimal ExtDiscountExcl
        => (OriginalPriceExcl - PriceExcl) * Qty * (int)ItemType;

}
