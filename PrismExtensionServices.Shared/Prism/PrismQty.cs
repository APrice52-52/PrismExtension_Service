using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCancelFeePlugin.Prism;
public class PrismQty
{
    public long? ItemSid { get; set; }
    public string? Alu { get; set; }
    public long? SbsSid { get; set; }
    public decimal? Qty { get; set; }

    public PrismQty Clone()
    {
        return new PrismQty()
        {
            ItemSid = this.ItemSid,
            Alu = this.Alu,
            SbsSid = this.SbsSid,
            Qty = this.Qty
        };
    }

}
