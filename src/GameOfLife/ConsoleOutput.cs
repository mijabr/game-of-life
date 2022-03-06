using System;

namespace GameOfLife
{
    public interface IOutput
    {
        void WriteLine(string s);
        void Clear();
    }

    public class ConsoleOutput : IOutput
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void WriteLine(string s)
        {
            Console.WriteLine(s);
        }
    }
}
