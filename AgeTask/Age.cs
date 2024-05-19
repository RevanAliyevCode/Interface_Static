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
            int age = now.Year - date.Year;

            if (date > now.AddYears(-age))
                age--;
            return age;
        }
    }
}
