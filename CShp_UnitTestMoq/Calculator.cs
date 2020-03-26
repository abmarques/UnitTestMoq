using System;

namespace CShp_UnitTestMoq
{
    public class Calculator : ICalculator
    {
        public (string op, double result) Calculate(string op, double a, double b)
        {
            (string op, double result) opResult;
            double c;
            switch (op)
            {
                case "add":
                    c = a + b;
                    break;
                case "sub":
                    c = a - b;
                    break;
                case "mult":
                    c = a * b;
                    break;
                case "div":
                    c = Math.Round(a / b, 2);
                    break;
                default:
                    c = a + b;
                    break;
            }
            opResult = (op, c);
            return opResult;
        }
    }
}
