using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    public static class ToUpperString
    {
        public static string CapitaliceString(this string word)
        {
            string upper = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (i == 0) upper += char.ToUpper(word[i]);
                else upper += word[i];
            }

            return upper;
        }
    }
}
