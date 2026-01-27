using traditional_no_top_level.Menu;
using traditional_no_top_level.Helpers;

namespace traditional_no_top_level.Tasks;

public class EchoAndSum : ITask
{
    public string Subject => "Basics";
    public string Title => "Echo and Sum";
    public string Description => "Reads two numbers and prints their sum. Demonstrates input parsing and simple output.";
    public int Number => 1;

    public void Run()
    {
        double a = InputHelpers.ReadDouble("Enter first number: ");
        double b = InputHelpers.ReadDouble("Enter second number: ");
        double sum = InputHelpers.Sum(a, b);

        Console.WriteLine($"\nResult:\n{a} + {b} = {sum}");
        InputHelpers.Wait();
    }
}