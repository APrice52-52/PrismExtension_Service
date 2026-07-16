using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if (!NETFR)
    namespace PrismExtensionServices.Shared.Prism;
#else
#nullable enable
namespace SoCancelFeePlugin
{
#endif

    public enum PrismInventoryLookup
{
    Alu = 1,
    Upc = 2,
    Sid = 3
}
#if (NETFR)
}
#endif
