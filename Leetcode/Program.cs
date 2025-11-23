var s = new Solution();

public class Solution
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        int hoursMet = 0;

        for (int i = 0; i < hours.Length; i++)
        {
            if (hours[i] >= target) hoursMet++;
        }
        
        return hoursMet;
    }
}