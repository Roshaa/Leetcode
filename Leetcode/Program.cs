Solution s = new Solution();

public class Solution
{
    public int[] LeftRightDifference(int[] nums)
    {
        int[] leftSum = new int[nums.Length];

        for (int i = 1; i < nums.Length; i++)
            leftSum[i] = leftSum[i - 1] + nums[i - 1];


        int[] rightSum = new int[nums.Length];

        for (int i = nums.Length - 2; i >= 0; i--)
            rightSum[i] = rightSum[i + 1] + nums[i + 1];


        int[] answer = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
            answer[i] = Math.Abs(leftSum[i] - rightSum[i]);

        return answer;
    }
}