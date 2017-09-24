using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalc
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var inputEngine = new InputEngine();
            var inputReader = new InputReader(inputEngine);
            var calculator = new Calculator();

            try
            {
                var test = new TestCalculator(inputReader, calculator, inputEngine);

                var result = test.Run();
            }
            catch (Exception ex)
            {
                inputEngine.Write(ex.Message);
            }

            inputEngine.ReadKey();

            return;
        }
    }
}