using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension.Extensions
{
    public static class StringExtension
    {
        public static string StringCut(this string currentString, int replaceIndex)
        {
            currentString = currentString.Remove(replaceIndex);
            currentString = currentString.Insert(replaceIndex, "...");
            return currentString;
        }

    }
}
