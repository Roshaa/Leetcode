public static class Solution
{
    public static int[] Shuffle(int[] nums, int n)
    {
        int[] ans = new int[nums.Length];

        int pos = 1;
        for(int i = n; i < nums.Length; i++)
        {
            ans[pos] = nums[i];
            pos+=2;
        }

        pos=0;
        for(int i = 0; i < n; i++)
        {
            ans[pos] = nums[i];
            j+=2;
        }


        return ans;
    }
}