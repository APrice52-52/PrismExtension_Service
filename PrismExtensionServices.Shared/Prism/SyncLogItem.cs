using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Prism;
internal class SyncLogItem
{
    public long Id { get; set; }
    public PrismType Type { get; set; }
    public long Sid { get; set; }
    public DateTime SyncDate{ get; set; }
    public string? SageRef { get; set; } = "";
}
