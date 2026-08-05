using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismExtensionServices.Shared.Serialization;
public static class JsonExtensions
{
    public static bool? ToBoolean(this string s)
    {
        if (s == null)
            return null;

        if (bool.TryParse(s, out bool result))
        {
            return result;
        }
        else
        {
            s = s.ToLower().Trim();
            if (s == "true" || s == "t" || s == "1") return true;
            else if (s == "false" || s == "f" || s == "0") return false;
            else throw new Exception($"'{s}' is not a valid boolean value.");
        }
    }
}
