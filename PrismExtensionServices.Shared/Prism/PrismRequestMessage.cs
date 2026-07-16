using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCancelFeePlugin.Prism;
internal class PrismRequestMessage<T>
{
    public List<T> data { get; set; } = new();
}
