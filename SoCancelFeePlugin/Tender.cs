using System;
using System.Collections.Generic;
using System.Text;

namespace SoCancelFeePlugin;

public class Tender
{
    public long TenderSid { get; set; }
    public long DocSid { get; set; }
    public int TenderType { get; set; } = 0;
    public decimal Amount { get; set; } = 0;
}
