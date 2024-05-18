using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    public static class Polindrom
    {
        public static bool FindIsPolindrom(this string word)
        {
            string revrse = new string(word.Revrese().ToArray());

            return revrse.ToLower() == word.ToLower();
        }
    }
}
