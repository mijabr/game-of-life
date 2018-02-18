using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] initialState = new char[,]
           {
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', 'X', '.', '.', '.', '.', '.', 'X', '.' },
                { '.', '.', '.', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', 'X', 'X', 'X', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', '.', '.', '.', '.', '.' },
                { '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X', 'X' },
                { '.', '.', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { '.', 'X', '.', '.', '.', '.', 'X', 'X', 'X', 'X' },
                { 'X', 'X', '.', '.', '.', '.', '.', '.', '.', '.' }
           };

            var grid = new GameOfLifeGrid(new ConsoleWrapper(), 10, 10);
            grid.Initalise(initialState);
            while (true)
            {
                grid.ApplyAllRules();
                grid.Display();
                Thread.Sleep(200);
            }
        }
    }
}
