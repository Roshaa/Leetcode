using System.Runtime.CompilerServices;

Console.WriteLine("Hello world");

Solution s = new Solution();
s.LargestLocal([[9, 9, 8, 1], [5, 6, 2, 6], [8, 2, 6, 4], [6, 2, 2, 2]]);
s.LargestLocal([[1,1,1,1,1],[1,1,1,1,1],[1,1,2,1,1],[1,1,1,1,1],[1,1,1,1,1]]);


public class Solution {
    public int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length;
        int[][] answer = new int[n - 2][];
        
        for (int i = 0; i < n - 2; i++)
        {
            answer[i] = new int[n - 2];
        }

        for (int i = 0; i < answer[0].Length; i++)
        {
            for (int j = 0; j < answer[0].Length; j++)
            {
                answer[i][j] = GetHighest3X3(i,j);
            }
        }

        return answer;

        int GetHighest3X3(int height, int horizontal)
        {
        int highest = 0;
        
        for (int i = height; i < height+3; i++)
        {
            for (int j = horizontal; j < horizontal + 3; j++)
            {
                if(grid[i][j] > highest)
                    highest = grid[i][j];
            }
        }

        return highest;
        }
    }
}