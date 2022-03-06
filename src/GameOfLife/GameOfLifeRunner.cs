using System.Text;

namespace GameOfLife
{
    public class GameOfLifeRunner
    {
        private readonly IOutput _output;
        private readonly IGrid _grid;

        public GameOfLifeRunner(IOutput output, IGrid grid)
        {
            _output = output;
            _grid = grid;
        }

        public void SetSize(int sizeX, int sizeY)
        {
            _grid.SetSize(sizeX, sizeY);
        }

        public void SetCells(string[] rows)
        {
            _grid.SetCells(rows);
        }

        public void Display()
        {
            _output.Clear();
            for (int y = 0; y < _grid.SizeY; y++)
            {
                StringBuilder outputLine = new();
                for (int x = 0; x < _grid.SizeX; x++)
                {
                    outputLine.Append(_grid.Cells[x, y]);
                }

                _output.WriteLine(outputLine.ToString());
            }
        }

        public void ApplyIteration()
        {
            var grid = new Grid();
            grid.SetSize(_grid.SizeX, _grid.SizeY);

            for (int y = 0; y < _grid.SizeY; y++)
            {
                for (int x = 0; x < _grid.SizeX; x++)
                {
                    int neighbours = _grid.GetNeighbourCount(x, y);
                    if (neighbours == 3)
                    {
                        grid.Cells[x, y] = 'X';
                    }
                    else if (neighbours == 2)
                    {
                        grid.Cells[x, y] = _grid.Cells[x, y];
                    }
                }
            }

            _grid.Cells = grid.Cells;
        }
    }
}
