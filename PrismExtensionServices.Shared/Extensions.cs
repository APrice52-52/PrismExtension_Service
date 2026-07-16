using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PrismExtensionServices.Shared;

public static class Extensions
{
    public static readonly NumberFormatInfo Nfi = new NumberFormatInfo() { NumberDecimalSeparator = ".", CurrencyDecimalSeparator = "." };

    public static string? SetMaxLength(this string? x, int length = 0) {
        if (x == null)
            return null;
        if (length == 0)
            return string.Empty;
        else if (x.Length < length)
            return x;
        else
            return x.Substring(0, length);
    }

    public static string? SetMaxLengthRev(this string x, int length = 0, bool trim = false) {
        if (x == null)
            return null;
        if (length == 0)
            return string.Empty;

        if (trim)
            x = x.Trim();

        if (x.Length < length)
            return x;
        else
            return x.Substring(x.Length - length, length);
    }


}
