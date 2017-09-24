using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalc
{
    internal class Calculator : ICalculator
    {
        public Calculator()
        {
        }

        public double Calculate(double a, ConsoleKey operation, double b)
        {
            double result = 0;

            if (Validate(a, operation, b))
            {
                switch (operation)
                {
                    case ConsoleKey.Add:
                        result = a + b;
                        break;

                    case ConsoleKey.Subtract:
                        result = a - b;
                        break;

                    case ConsoleKey.Multiply:
                        result = a * b;
                        break;

                    case ConsoleKey.Divide:
                        result = a / b;
                        break;

                    default:
                        break;
                }
            }

            return result;
        }

        private bool Validate(double a, ConsoleKey operation, double b)
        {
            // Add whatever logic here
            return true;
        }
    }
}