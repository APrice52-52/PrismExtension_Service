using System;
using System.Collections.Generic;
using System.Text;

namespace SoCancelFeePlugin;

internal class SoCancelFeePluginConfig
{
    public decimal FeePercentage { get; set; } = 0;
    public bool FeeOnTotal { get; set; } = true;
    public int FeeType { get; set; } = 0;
}
