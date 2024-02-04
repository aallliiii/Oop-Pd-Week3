using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.BL
{
    internal class CalculatorClass
    {
        public double value1;
        public double value2;

        public CalculatorClass(double Val1, double Val2)
        {
            value1 = Val1;
            value2 = Val2;
        }
        public CalculatorClass()
        {
            value1 = 10;
            value2 = 10;
        }
        public double Add()
        {
            double result = value1 + value2;
            return result;
        }
        public double Subtract()
        {
            double result = value1 - value2;
            return result;
        }
        public double Divide()
        {
            double result = value1 / value2;
            return result;
        }
        public double Multiply()
        {
            double result = value1 * value2;
            return result;
        }
        public double Mod()
        {
            double result = value1 % value2;
            return result;
        }
        public double SquareRoot()
        {
            double answer = (Math.Sqrt(value1));
            return answer;
        }
        public double Exponent()
        {
            double answer = (Math.Exp(value1));
            return answer;
        }
        public double Log()
        {
            double answer = (Math.Log(value1));
            return answer;
        }
        public double Sin()
        {
            double answer = (Math.Sin(value1));
            return answer;
        }
        public double Cos()
        {
            double answer = (Math.Cos(value1));
            return answer;
        }
        public double Tan()
        {
            double answer = (Math.Tan(value1));
            return answer;
        }

    }



}

