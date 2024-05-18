using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    public static class Average
    {
        public static double FindAverage(this int[] nums)
        {
            int sum = 0;

            foreach (int x in nums) sum += x;

            return sum / nums.Length;
        }
    }
}
