public class Solution
{
    public char FindTheDifference(string s, string t)
    {
        char[] sChars = s.ToCharArray();
        Array.Sort(sChars);

        char[] tChars = t.ToCharArray();
        Array.Sort(tChars);

        for (int i = 0; i < sChars.Length; i++)
        {
            if (sChars[i] != tChars[i])
            {
                return tChars[i];
            }
        }

        return tChars[tChars.Length - 1];
    }
}