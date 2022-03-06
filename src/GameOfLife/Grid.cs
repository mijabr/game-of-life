namespace GameOfLife
{
    public interface IGrid
    {
        char[,] Cells { get; set; }
        int SizeX { get; }
        int SizeY { get; }
        void SetSize(int sizeX, int sizeY);
        void SetCells(string[] rows);
        int GetNeighbourCount(int x, int y);
    }

    public class Grid : IGrid
    {
        public char[,] Cells { get; set; } = new char[1, 1];

        public int SizeX => Cells.GetLength(0);

        public int SizeY => Cells.GetLength(1);

        private void Clear()
        {
            for (int y = 0; y < SizeY; y++)
                for (int x = 0; x < SizeX; x++)
                    Cells[x, y] = '.';
        }

        public void SetSize(int sizeX, int sizeY)
        {
            Cells = new char[sizeX, sizeY];
            Clear();
        }

        public void SetCells(string[] rows)
        {
            var sizeX = rows[0].Length;
            var sizeY = rows.Length;
            Cells = new char[sizeX, sizeY];
            for (int y = 0; y < sizeY; y++)
            {
                for (int x = 0; x < sizeX; x++)
                {
                    Cells[x, y] = rows[y][x];
                }
            }
        }

        public int GetNeighbourCount(int x, int y)
        {
            int startY = y - 1;
            int endY = y + 1;

            int startX = x - 1;
            int endX = x + 1;

            if (startY < 0)
            {
                startY = 0;
            }

            if (endY >= SizeY)
            {
                endY = SizeY - 1;
            }

            if (startX < 0)
            {
                startX = 0;
            }

            if (endX >= SizeX)
            {
                endX = SizeX - 1;
            }

            var count = 0;
            for (int i = startY; i <= endY; i++)
            {
                for (int j = startX; j <= endX; j++)
                {
                    if (Cells[j, i] == 'X' && !(i == y && j == x))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
