using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCancelFeePlugin.Prism;
public class PrismPrice
{
    public long? ItemSid { get; set; }
    public string? Alu { get; set; }
    public long? SbsSid { get; set; }
    public long? PriceLevelSid { get; set; }
    public int? PriceLevel { get; set; }
    public string? PriceLevelName { get; set; }
    public decimal? Price { get; set; }

    public PrismPrice Clone()
    {
        return new PrismPrice()
        {
            ItemSid = this.ItemSid,
            Alu = this.Alu,
            SbsSid = this.SbsSid,
            PriceLevelSid = this.PriceLevelSid,
            PriceLevel = this.PriceLevel,
            PriceLevelName = this.PriceLevelName,
            Price = this.Price
        };
    }
}
