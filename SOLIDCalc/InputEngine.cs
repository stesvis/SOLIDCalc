using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalc
{
    /// <summary>
    /// This class is to decouple the input provider If one day we decide to read the input from a
    /// web UI we just modify this class
    /// </summary>
    public class InputEngine : IInputEngine
    {
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey(true);
        }

        public void Write(string text)
        {
            Console.Write(text);
        }

        public void Write(char text)
        {
            Console.Write(text);
        }
    }
}