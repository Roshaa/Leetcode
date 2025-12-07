public class Solution
{
    public int MaxDistinct(string s)
    {
        HashSet<char> hash = new HashSet<char>();

        foreach (char c in s)
            if (!hash.Contains(c)) hash.Add(c);

        return hash.Count;
    }
}