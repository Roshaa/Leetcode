public class Solution
{
    public int[] FindIntersectionValues(int[] nums1, int[] nums2)
    {
        int left = 0;
        int right = 0;

        for (int i = 0; i < nums1.Length; i++)
        {
            if (nums2.Contains(nums1[i])) left++;
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (nums1.Contains(nums2[i])) right++;
        }

        int[] ans = new int[2];
        ans[0] = left;
        ans[1] = right;

        return ans;
    }
}