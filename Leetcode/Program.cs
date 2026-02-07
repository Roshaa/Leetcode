public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        int totalDuration = timeSeries.Length * duration;

        for (int i = 1; i < timeSeries.Length; i++)
        {
            int gap = timeSeries[i] - timeSeries[i - 1];

            if (gap < duration)
            {
                totalDuration -= (duration - gap);
            }
        }

        return totalDuration;
    }
}