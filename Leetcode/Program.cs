public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int number in arr)
        {
            if (dict.ContainsKey(number))
            {
                dict[number]++;
            }
            else
            {
                dict[number] = 1;
            }
        }

        HashSet<int> seen = new HashSet<int>();

        foreach (int count in dict.Values)
        {
            if (!seen.Add(count))
                return true;
        }

        return false;
    }
}