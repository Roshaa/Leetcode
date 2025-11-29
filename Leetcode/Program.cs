public class Solution
{
    public int CountAsterisks(string s)
    {
        while (s.Contains("|"))
        {
            int start = s.IndexOf("|");
            int end = s.IndexOf("|", start + 1);
            if (end == -1) break;
            s = s.Remove(start, end - start + 1);
        }

        int count = 0;
        foreach (char c in s)
            if (c == '*') count++;

        return count;
    }
}