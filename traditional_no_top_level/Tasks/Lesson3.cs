using traditional_no_top_level.Helpers;
using traditional_no_top_level.Menu;

namespace traditional_no_top_level.Tasks;

public class Calculator : ITask
{
    public string Title => "Calculator";
    public string Description => "Prompts user for numbers and allows calculations to be done.\nCatches invalid input.";
    public string Subject => "Methods";
    public int Number => 1;
    
    public void Run()
    {
        // Purpose: Act as a small calculator using reusable methods
        Console.WriteLine("=== Lesson 3: Methods and reuse ===");
        
        double a = ReadDouble("Enter first number: ");
        double b = ReadDouble("Enter second number: ");
        
        Console.WriteLine($"Add:\n{a} + {b} = {Add(a, b)}");
        Console.WriteLine($"Subtract:\n{a} - {b} = {Subtract(a, b)}");
        Console.WriteLine($"Multiply:\n{a} * {b} = {Multiply(a, b)}");
        
        double div = Divide(a, b);
        if (double.IsNaN(div))
            Console.WriteLine("Divide: Not a number (division by zero)");
        else
            Console.WriteLine($"Divide:\n{a} / {b} = {div}");
    }
    
    // Calculator methods (pure functions)
    // Signature: methods name "Add", params x and y (double), returns double
    private static double Add(double x, double y) => x + y;
    private static double Subtract(double x, double y) => x - y;
    
    private static double Multiply(double x, double y) => x * y;

    private static double Divide(double x, double y)
    {
        if (y == 0)
        {
            // Defensive check: protect against invalid operations
            Console.WriteLine("Warning: Divide by zero not allowed.");
            return double.NaN; // Sentinel value indicating invalid result.
        }
        return x / y;
    }
    
    // Input helper
    private static double ReadDouble(string prompt)
    {
        while (true) // Loop until valid input received
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            
            // TryParse avoids exceptions and indicates success/failure with a bool
            if (double.TryParse(s, out double value))
                return value;
            Console.WriteLine("Invalid number. Try again using digits, decimal point if needed.");
        }
    }
}