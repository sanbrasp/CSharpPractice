using traditional_no_top_level.Helpers;
using traditional_no_top_level.Menu;
using traditional_no_top_level.Menu;

namespace traditional_no_top_level;

public class BranchingLoops : ITask
{
    public string Subject => "Basics";
    public string Title => "Branching and Loops";
    public string Description => "Reads an integer n and prints numbers 1..n with even/odd labels using for and if.";
    public int Number => 2;

    public void Run()
    {
        int n = InputHelpers.ReadInt("Enter number 'n' (positive): ");
        if (n <= 0)
        {
            Console.WriteLine("Number 'n' must be positive.");
            InputHelpers.Wait();
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            string kind = (i % 2 == 0) ? "even" : "odd";
            Console.WriteLine($"{i} is {kind}.");
        }
        InputHelpers.Wait();
    }
}