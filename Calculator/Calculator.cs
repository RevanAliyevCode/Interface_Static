using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public Calculator(int numberOne, int numberTwo)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
        }

        public void Sum()
        {
            Console.WriteLine($"{NumberOne} + {NumberTwo} = {NumberOne + NumberTwo}");
        }

        public void Multible()
        {
            Console.WriteLine($"{NumberOne} * {NumberTwo} = {NumberOne * NumberTwo}");
        }

        public void Substract()
        {
            Console.WriteLine($"{NumberOne} - {NumberTwo} = {NumberOne - NumberTwo}");
        }

        public void Divide()
        {
            Console.WriteLine($"{NumberOne} / {NumberTwo} = {NumberOne / NumberTwo}");
        }
    }
}
