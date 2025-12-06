public class Solution
{
    public int PrefixCount(string[] words, string pref)
    {
        int counter = 0;

        foreach (string s in words)
            if (s.StartsWith(pref)) counter++;

        return counter;
    }
}