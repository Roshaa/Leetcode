public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        HashSet<int> uniqueNumbers = new HashSet<int>();
        int duplicate = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (uniqueNumbers.Contains(nums[i]))
            {
                duplicate = nums[i];
                break;
            }
            uniqueNumbers.Add(nums[i]);
        }

        return duplicate;
    }
}