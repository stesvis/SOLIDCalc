using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalc
{
    public class InputReader : IInputReader
    {
        private IInputEngine _engine;

        public InputReader(IInputEngine engine)
        {
            _engine = engine;
        }

        public double ReadNumber()
        {
            StringBuilder input = new StringBuilder();
            ConsoleKeyInfo ckey;

            while ((ckey = _engine.ReadKey()).Key != ConsoleKey.Enter || (ckey.Key == ConsoleKey.Enter && string.IsNullOrWhiteSpace(input.ToString())))
            {
                if (Char.IsDigit(ckey.KeyChar))
                {
                    _engine.Write(ckey.KeyChar);
                    input.Append(ckey.KeyChar);
                }
                if (ckey.Key == ConsoleKey.Backspace)
                {
                    input.Length--;
                    _engine.Write("\b \b");
                }
            }

            _engine.Write(Environment.NewLine);

            return double.Parse(input.ToString());
        }

        public ConsoleKey ReadOperation()
        {
            ConsoleKeyInfo ckey;
            ConsoleKey operation;

            do
            {
                ckey = _engine.ReadKey();

                if (
                    ckey.Key == ConsoleKey.Add ||
                    ckey.Key == ConsoleKey.Subtract ||
                    ckey.Key == ConsoleKey.Multiply ||
                    ckey.Key == ConsoleKey.Divide
                )
                {
                    operation = ckey.Key;
                    _engine.Write(ckey.KeyChar);
                    break;
                }
            } while (true);

            _engine.Write(Environment.NewLine);

            return operation;
        }
    }
}