using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if (!NETFR)
    namespace SoCancelFeePlugin.Prism;
#else
#nullable enable
namespace SoCancelFeePlugin
{
#endif
public enum PrismCustomerLookup
{
    CustomerId = 0,
    Email = 1,
    Alternate_Id1 = 2,
    Alternate_Id2 = 3,
    Info1 = 4,
    Info2 = 5,
    Sid = 6
}
#if (NETFR)
}
#endif
