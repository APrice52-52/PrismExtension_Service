using System;
using System.Collections.Generic;
using System.Text;

namespace SoCancelFeePlugin;

public class CancellationMessage
{
    public long SoSid { get; set; }
    public long EmployeeSid { get; set; }
    public string EmployeeName { get; set; } = string.Empty;
    public long StoreSid { get; set; }
    public List<Tender> Tenders { get; set; } = new List<Tender>();
}
