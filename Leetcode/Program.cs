Solution s = new Solution();

public class Solution
{
    public IList<int> StableMountains(int[] height, int threshold)
    {
        List<int> list = new();

        for (int i = 1; i < height.Length; i++)
            if (height[i - 1] > threshold) list.Add(i);

        return list;
    }
}