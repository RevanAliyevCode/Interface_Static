using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeTask
{
    public static class Age
    {
        public static int AgeCalculator(this DateTime date)
        {
            DateTime now = DateTime.Now;
            if (now.Month - date.Month >= 0 && now.Day - date.Day >= 0)
            {
                return now.Year - date.Year;
            }
            return now.Year - date.Year - 1;
        }
    }
}
