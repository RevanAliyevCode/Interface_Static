using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    public static class Reverse
    {
        public static string Revrese(this string word)
        {
            string reversedArr = "";
            for (int i = word.Length - 1; i >= 0; i--)
                reversedArr += word[i];

            return reversedArr;
        }
    }
}
