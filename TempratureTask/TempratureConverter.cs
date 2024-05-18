using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempratureTask
{
    public static class TempratureConverter
    {
        public static double CelsiusToFahrenheit(double tepmrature)
        {
            return (tepmrature * 1.8) + 32;
        }

        public static double FahrenheitToCelsius(double tepmrature)
        {
            return (tepmrature - 32) / 1.8;
        }
    }
}
