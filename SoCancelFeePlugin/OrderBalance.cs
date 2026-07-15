using System;
using System.Collections.Generic;
using System.Text;

namespace SoCancelFeePlugin;

public class OrderBalance
{
    public long SoSid { get; set; }
    public decimal Balance { get; set; } = 0;
    public decimal FeePercentage { get; set; } = 0;
    public decimal FeeAmount { get; set; } = 0;
    public int FeeType { get; set; } = 0;
    public bool FeeOnTotal { get; set; } = true;
}
