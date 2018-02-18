using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class GameOfLifeGrid
    {
        private int Row;
        private int Column;

        private char[,] arr;
        private IConsole _Console;
        public GameOfLifeGrid(IConsole _Console, int row, int column)
        {
            this.Row = row;
            this.Column = column;

            this.arr = new char[row, column];
            this._Console = _Console;

            Intialise();
        }

        private void Intialise()
        {
            for (int colIdx = 0; colIdx < Column; colIdx++)
                for (int rowIdx = 0; rowIdx < Row; rowIdx++)
                    arr[rowIdx, colIdx] = '.';
        }

        public void Display()
        {
            _Console.Clear();
            for (int rowIdx = 0; rowIdx < Row; rowIdx++)
            {
                string line = "";
                for (int colIdx = 0; colIdx < Column; colIdx++)
                {
                    line += arr[rowIdx, colIdx];
                }

                _Console.WriteLine(line);
            }
        }

        public void Initalise(char[,] initialState)
        {
            this.arr = initialState;
        }

        public void ApplyUnderPopulation(char[,] clonedArray)
        {
            ApplyRule(2, 1, clonedArray);
        }

        public void ApplyOverPopulationRule(char[,] clonedArray)
        {
            ApplyRule(3, 2, clonedArray);
        }

        public void ApplyProcreationRule(char[,] clonedArray)
        {
            ApplyRule(3, 3, clonedArray);
        }

        public void ApplySurvivalRule(char[,] clonedArray)
        {
            ApplyRule(3, 1, clonedArray);
        }

        private void ApplyRule(int range, int compare, char[,] clonedArray)
        {
            for (int row = 0; row < Row; row++)
            {
                for (int column = 0; column < Column; column++)
                {
                    if (compare==1)
                    {
                        if (LiveNeighbourCount(row, column, clonedArray) < range)
                        {
                            arr[row, column] = '.';
                        }
                    }
                    else if (compare==2)
                    {
                        if (LiveNeighbourCount(row, column, clonedArray) > range)
                        {
                            arr[row, column] = '.';
                        }
                    }
                    else
                    {
                        if (LiveNeighbourCount(row, column, clonedArray) == range)
                        {
                            arr[row, column] = 'X';
                        }
                    }

                }
            }
        }


        public int LiveNeighbourCount(int row, int column, char[,] array)
        {
            int startRow = row - 1;
            int endRow = row + 1;

            int startCol = column - 1;
            int endCol = column + 1;

            if (startRow < 0)
            {
                startRow = 0;
            }

            if (endRow >= Row)
            {
                endRow = Row - 1;
            }

            if (startCol < 0)
            {
                startCol = 0;
            }

            if (endCol >= Column)
            {
                endCol = Column - 1;
            }

            var count = 0;
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    if (i == row && j == column)
                    {
                        continue;
                    }

                    if (array[i, j] == 'X')
                    {
                        count++;
                    }
                }
            }


            return count;
        }

        public void ApplyAllRules()
        {
            char[,] clonedArray = (char[,])arr.Clone();

            ApplyOverPopulationRule(clonedArray);
            ApplyProcreationRule(clonedArray);
            //ApplySurvivalRule(clonedArray);
            ApplyUnderPopulation(clonedArray);
        }
    }
}
