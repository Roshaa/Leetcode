using System.Text;

public class Solution
{
    public string RemoveOuterParentheses(string s)
    {
        int findOuter = 0;
        var sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                if (findOuter > 0)
                    sb.Append(s[i]);

                findOuter++;
            }
            else
            {
                findOuter--;

                if (findOuter > 0)
                    sb.Append(s[i]);
            }
        }

        return sb.ToString();
    }
}