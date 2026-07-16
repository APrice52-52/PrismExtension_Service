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

public enum PrismDocumentLookup
{
    TrackingNumber = 0,
    Sid = 1,
    CustomField = 2,
    Custom0 = 3,
    Custom1 = 4,
    Custom2 = 5,
    Custom3 = 6,
    Custom4 = 7
}
#if (NETFR)
}
#endif
