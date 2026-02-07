public class Solution
{
    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1] + 1)
            {
                return nums[i - 1] + 1;
            }
        }

        int lastNum = nums[nums.Length - 1];
        int firstNum = nums[0];

        int answer = lastNum + 1;

        if (firstNum != 0)
            return 0;

        return answer;
    }
}