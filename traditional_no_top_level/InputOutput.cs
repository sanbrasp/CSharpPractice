using traditional_no_top_level.Menu;

namespace traditional_no_top_level;

public class InputOutput : ITask
{
    public string Title => "Input / Output";
    public string Description => "Reads string input and prints it back to console.";
    public string Subject => "Input/Output";
    public int Number => 1;
    
    public void Run()
    {
        Console.WriteLine("Welcome to C# (Traditional)!");
        Console.Write("What is your name? ");
        string? name = Console.ReadLine();
    }
}