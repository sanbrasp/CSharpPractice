using traditional_no_top_level.Menu;

namespace traditional_no_top_level;

public class InputOutputNumbers : ITask
{
    public string Title => "Input / Output - Numbers";
    public string Description => "Reads number, uses if-else to decide age group.";
    public string Subject => "Input/Output";
    public int Number => 2;
    
    public void Run()
    {
        Console.Write("Enter your age: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age < 0)
                Console.WriteLine("Age cannot be negative.");
            else if (age < 18)
                Console.WriteLine("You are a minor.");
            else
                Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("Please enter a valid whole number.");
        }
    }
}