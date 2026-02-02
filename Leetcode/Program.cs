public class Solution
{
    public string ReversePrefix(string s, int k)
    {
        char[] lettersToReverse = new char[k];

        for (int i = 0; i < k; i++)
            lettersToReverse[i] = s[i];

        Array.Reverse(lettersToReverse);
        char[] sArray = s.ToCharArray();

        for (int i = 0; i < k; i++)
            sArray[i] = lettersToReverse[i];

        return new string(sArray);
    }
}