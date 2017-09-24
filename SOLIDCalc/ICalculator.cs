using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalc
{
    public interface ICalculator
    {
        double Calculate(double a, ConsoleKey operation, double b);
    }
}