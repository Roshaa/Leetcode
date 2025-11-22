Console.WriteLine("Hello world");




public class Solution {
    public string Interpret(string command) {
        return command.Replace("()", "o").Replace("(al)", "al");
    }
}