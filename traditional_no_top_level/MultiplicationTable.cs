using traditional_no_top_level.Menu;
using traditional_no_top_level.Helpers;

namespace traditional_no_top_level;

public class MultiplicationTable : ITask
{
    public string Subject => "Basics";
    public string Title => "Multiplication Table";
    public string Description => "Prints an n x n multiplication table with formatted columns.";
    public int Number => 3;

    public void Run()
    {
        int n = InputHelpers.ReadInt("Multiply number (e.g., 10): ");
        if (n <= 0 || n > 20)
        {
            Console.WriteLine("Choose 1 - 20 to keep it readable.");
            InputHelpers.Wait();
            return;
        }

        Console.WriteLine("             ");
        for (int j = 1; j <= n; j++) Console.Write($"{j,4}");
        Console.WriteLine("\n" + new string('-', 5 + 4 * n));

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"{i,4}|");
            for (int j = 1; j <= n; j++) Console.Write($"{i * j,4}");
            Console.WriteLine();
        }
        InputHelpers.Wait();
    }

}