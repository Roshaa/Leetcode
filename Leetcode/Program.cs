public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>(nums);

        int longestStreak = 0;

        foreach (int n in numSet)
        {
            if (numSet.Contains(n - 1))
                continue;

            int currentStreak = 1;
            bool hasSequence = numSet.Contains(n + 1);

            while (hasSequence)
            {
                currentStreak++;
                hasSequence = numSet.Contains(n + currentStreak);
            }

            longestStreak = Math.Max(longestStreak, currentStreak);
        }

        return longestStreak;

    }
}