using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class ConsoleWrapper : IConsole
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }

        public void WriteLine(char c)
        {
            throw new NotImplementedException();
        }
    }
}
