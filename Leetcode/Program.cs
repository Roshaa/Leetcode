Solution s = new Solution();

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int minCost = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            int profit = prices[i] - minCost;
            if (profit > 0 && profit > maxProfit) maxProfit = profit;

            if (prices[i] < minCost)
                minCost = prices[i];
        }

        return maxProfit;
    }
}