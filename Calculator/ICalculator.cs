using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculator
    {
        int NumberOne { get; set; }
        int NumberTwo { get; set; }

        void Sum();
        void Multible();
        void Substract();
        void Divide();
    }
}
