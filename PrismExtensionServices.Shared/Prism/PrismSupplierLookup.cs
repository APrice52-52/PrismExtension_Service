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


    public enum PrismSupplierLookup
{
    VendorCode = 1,
    VendorId = 2,
    Info1 = 3,
    Info2 = 4,
    AccountNo = 5,
    Sid = 6
}
#if (NETFR)
}
#endif
