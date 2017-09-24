using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCalc
{
    public interface IInputEngine
    {
        ConsoleKeyInfo ReadKey();

        void Write(string text);

        void Write(char text);
    }
}