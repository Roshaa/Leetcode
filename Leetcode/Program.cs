public class Solution
{
    public bool JudgeCircle(string moves)
    {
        int[] position = new int[2] { 0, 0 };
        foreach (char move in moves)
        {
            switch (move)
            {
                case 'L':
                    position[0]--;
                    break;
                case 'R':
                    position[0]++;
                    break;
                case 'U':
                    position[1]++;
                    break;
                case 'D':
                    position[1]--;
                    break;
            }
        }

        return position[0] == 0 && position[1] == 0;
    }
}