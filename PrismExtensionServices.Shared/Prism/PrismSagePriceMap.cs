using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if (!NETFR)
namespace SoCancelFeePlugin.Prism
#else
namespace SoCancelFeePlugin
#endif
{
    public struct PrismSagePriceMap
    {
        [DisplayName("Price Level Sid")]
        public long Sid { get; set; }
        [DisplayName("Sage Price Level Name")]
        public string? SageName { get; set; }
        [DisplayName("Sage Price Level Id")]
        public long? SageId { get; set; }

        public override string ToString()
        {
            return $"{SageName}/{Sid}";
        }
    }
}
