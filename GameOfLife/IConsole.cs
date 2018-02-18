using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public interface IConsole
    {
        void WriteLine(char c);
        void WriteLine(string s);
        void Clear();
    }
}
