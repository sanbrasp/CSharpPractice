using traditional_no_top_level.Menu;
using traditional_no_top_level.Helpers;
using System.Linq;

namespace traditional_no_top_level;

public class PalindromeChecker : ITask
{
    public string Subject => "Strings";
    public string Title => "Palindrome Checker";
    public string Description => "Checks if a string is a palindrome (ignoring case and non-letters).";
    public int Number => 1;

    public void Run()
    {
        Console.Write("Enter text: ");
        string? s = Console.ReadLine() ?? string.Empty;
        
        string lettersOnly = new
            string(s.Where(char.IsLetter).ToArray()).ToLowerInvariant();
        string reversed = new string(lettersOnly.Reverse().ToArray());

        Console.WriteLine(lettersOnly == reversed ? "Palindrome" : "Not Palindrome");
    }

}