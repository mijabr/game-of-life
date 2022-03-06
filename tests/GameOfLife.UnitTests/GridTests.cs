using FluentAssertions;
using NUnit.Framework;

namespace GameOfLife.UnitTests
{
    public class GridTests
    {

        [Test]
        public void SetSize_ShouldInitialiseWithEmptyCells()
        {
            Grid grid = new();

            grid.SetSize(10, 20);

            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    grid.Cells[x, y].Should().Be('.');
                }
            }
        }

        [Test]
        public void SetCells_ShouldSetGridCells_GivenStringArray()
        {
            Grid grid = new();
            grid.SetCells(new string[]
            {
                "XX.",
                "..X",
                "..."
            });

            grid.Cells[0, 0].Should().Be('X');
            grid.Cells[1, 0].Should().Be('X');
            grid.Cells[2, 0].Should().Be('.');

            grid.Cells[0, 1].Should().Be('.');
            grid.Cells[1, 1].Should().Be('.');
            grid.Cells[2, 1].Should().Be('X');

            grid.Cells[0, 2].Should().Be('.');
            grid.Cells[1, 2].Should().Be('.');
            grid.Cells[2, 2].Should().Be('.');
        }

        [Test]
        public void GetNeighbourCount_ShouldReturnTheCountOfLiveNeighbouringCells_GivenCellCoordinates()
        {
            Grid grid = new();
            grid.SetCells(new string[]
            {
                "...",
                "XX.",
                "..X"
            });

            grid.GetNeighbourCount(0, 0).Should().Be(2);
            grid.GetNeighbourCount(1, 0).Should().Be(2);
            grid.GetNeighbourCount(2, 0).Should().Be(1);

            grid.GetNeighbourCount(0, 1).Should().Be(1);
            grid.GetNeighbourCount(1, 1).Should().Be(2);
            grid.GetNeighbourCount(2, 1).Should().Be(2);

            grid.GetNeighbourCount(0, 2).Should().Be(2);
            grid.GetNeighbourCount(1, 2).Should().Be(3);
            grid.GetNeighbourCount(2, 2).Should().Be(1);
        }
    }
}
