public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        {
            int perimeter = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    bool isLand = grid[i][j] == 1;
                    perimeter += grid[i][j] * 4;

                    if (isLand && j > 0)
                        perimeter -= grid[i][j - 1] * 2;

                    if (isLand && i < grid.Length - 1)
                        perimeter -= grid[i + 1][j] * 2;

                }
            }

            return perimeter;
        }
    }
}