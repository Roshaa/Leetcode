var s = new Solution();

var dd = s.ReversePrefix("abcdefd", 'd');


public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        int index = word.IndexOf(ch);

        if (index == -1) return word;

        char[] array1 = new char[index + 1];
        for (int i = index; i > -1; i--)
            array1[index - i] = word[i];




        string notToReplace = word.Substring(index + 1);

        string ans = new string(array1) + notToReplace;

        return ans;

    }
}