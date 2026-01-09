
namespace traditional_no_top_level;

public static class Lesson1
{
    public static void Run()
    {
        Console.WriteLine("Welcome to C# (Top-Level)!");
        Console.Write("What is your name? ");
        string? name = Console.ReadLine();

        Console.WriteLine($"Hello {name}!");
        Console.Write("Press Enter to exit...");
        Console.ReadLine(); // Keeps window open in some shells
    }
}
