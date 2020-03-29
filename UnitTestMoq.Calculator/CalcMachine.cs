using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestMoq.Calculator
{
    public class CalcMachine
    {
        private ICalculator calc;

        public CalcMachine() : this(new Calculator())
        {

        }

        public CalcMachine(ICalculator obj)
        {
            this.calc = obj;
        }

        public (string op, double result) Calculate(string OpType, double a, double b)
        {
            return calc.Calculate(OpType, a, b);
        }
    }
}
