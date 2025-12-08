public class Solution
{
    public int MinMovesToSeat(int[] seats, int[] students)
    {
        seats = seats.OrderBy(n => n).ToArray();
        students = students.OrderBy(n => n).ToArray();

        int moves = 0;
        for (int i = 0; i < seats.Length; i++)
        {
            moves += Math.Abs(seats[i] - students[i]);
        }

        return moves;
    }
}