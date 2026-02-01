Solution s = new Solution();
//int result = s.Leet(7, new int[] { 2, 3, 1, 2, 4, 3 });
int result = s.Leet(7, new int[] { 10, 2, 3 });
//int result = s.Leet(11, new int[] { 1, 1, 1, 1, 1, 1, 1, 1 });


public class Solution
{
    public int Leet(int target, int[] nums)
    {
        int answer = int.MaxValue;
        int currentSum = nums[0];
        int leftPointer = 0;

        if (currentSum >= target)
            return 1;

        for (int rightPointer = 1; rightPointer < nums.Length; rightPointer++)
        {
            currentSum += nums[rightPointer];

            if (currentSum >= target)
            {
                while (currentSum >= target && leftPointer <= rightPointer)
                {
                    int diff = rightPointer - leftPointer + 1;

                    if (diff < answer)
                        answer = diff;

                    currentSum -= nums[leftPointer];
                    leftPointer++;

                }
            }


        }

        return answer == int.MaxValue ? 0 : answer;
    }
}