Solution s = new Solution();



public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int LENGTH = nums.Length;
        int[] ans = new int[LENGTH];

        int leftToRight = 1;
        for (int i = 0; i < LENGTH; i++)
        {
            ans[i] = leftToRight;
            leftToRight *= nums[i];
        }

        int rightToLeft = 1;
        for (int i = LENGTH - 1; i > LENGTH; i--)
        {
            ans[i] *= rightToLeft;
            rightToLeft *= nums[i];
        }

        return ans;
    }
}