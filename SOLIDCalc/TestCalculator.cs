using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalc
{
    public class TestCalculator
    {
        private IInputReader _inputReader;
        private ICalculator _calculator;
        private IInputEngine _engine;

        public TestCalculator(IInputReader inputReader, ICalculator calculator, IInputEngine engine)
        {
            _inputReader = inputReader;
            _calculator = calculator;
            _engine = engine;
        }

        public double Run()
        {
            _engine.Write("First number: ");
            var inputA = _inputReader.ReadNumber();

            _engine.Write("Operation: ");
            var operation = _inputReader.ReadOperation();

            _engine.Write("Second number: ");
            var inputB = _inputReader.ReadNumber();

            var result = _calculator.Calculate(inputA, operation, inputB);

            _engine.Write(result.ToString());

            return result;
        }
    }
}