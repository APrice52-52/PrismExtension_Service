#region Credits
/* 
 * Portions of base conversion code adapted from 
 * http://stackoverflow.com/a/7398730/141508
 * (Jon, CC BY-SA 3.0 license, http://creativecommons.org/licenses/by-sa/3.0/), and
 * http://www.stum.de/2008/10/20/base36-encoderdecoder-in-c/ 
 * (Michael Stum, MIT License)
 * 
 * Balance of code provided under the Code Project Open License:
 * http://www.codeproject.com/info/cpol10.aspx
 */
#endregion
#region MIT License
/*
 * Copyright (c) <year> <copyright holders>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;

namespace Base36;

/// <summary>
/// A Base36 De- and Encoder
/// </summary>
/// <remarks>
/// Portions of this adapted from the base36 encoder at
/// http://www.stum.de/2008/10/20/base36-encoderdecoder-in-c/
/// </remarks>
internal static class BaseConverter
{
    private static string _charList = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    
    /// <summary>
    /// The character set for encoding. Defaults to upper-case alphanumerics 0-9, A-Z.
    /// </summary>
    public static string CharList { get { return _charList; } set { _charList = value; } }   
    private static char[] CharArray = CharList.ToCharArray();
    public static string Convert(string number, int fromBase, int toBase)
    {
        // var digits = "0123456789abcdefghijklmnopqrstuvwxyz";
        int length = number.Length;
        string result = string.Empty;
        List<int> nibbles = number.Select(c => CharList.IndexOf(c)).ToList();
        int newlen;
        do
        {
            int value = 0;
            newlen = 0;
            for (var i = 0; i < length; ++i)
            {
                value = value * fromBase + nibbles[i];
                if (value >= toBase)
                {
                    if (newlen == nibbles.Count)
                    {
                        nibbles.Add(0);
                    }
                    nibbles[newlen++] = value / toBase;
                    value %= toBase;
                }
                else if (newlen > 0)
                {
                    if (newlen == nibbles.Count)
                    {
                        nibbles.Add(0);
                    }
                    nibbles[newlen++] = 0;
                }
            }
            length = newlen;
            result = CharList[value] + result; //
        }
        while (newlen != 0);
        return result;
    }
}