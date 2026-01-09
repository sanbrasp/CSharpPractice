
namespace top_level_statements;

public static class TopLesson1
{
    public static void RunIt()
    {
        Console.WriteLine("Welcome to C# (Top-Level)!");
        Console.Write("What is your name? ");
        string? name = Console.ReadLine();

        Console.WriteLine($"Hello {name}!");
        Console.Write("Press Enter to exit...");
        Console.ReadLine(); // Keeps window open in some shells
    }
}
