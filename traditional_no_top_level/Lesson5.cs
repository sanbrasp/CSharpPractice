using traditional_no_top_level.Menu;
// Lesson5.cs
namespace traditional_no_top_level;

public class MethodsAndParameters : ITask
{
    // Entry point for the lesson
    public string Title => "Methods and Parameters";
    public string Description => "Calculation methods with parameters (using helpers).";
    public string Subject => "Methods";
    public int Number => 2;
    
    public void Run()
    {
        Console.WriteLine("=== Lesson 5: Methods & Parameters ===");

        // 1) Basic method call with parameters and return value
        int sum = Add(10, 32);
        Console.WriteLine($"Add(10, 32) = {sum}");

        // 2) Optional parameters and named arguments
        // Default taxRate is used when not provided.
        double totalWithDefaultTax = CalculateTotal(100.0);
        Console.WriteLine($"CalculateTotal(100.0) [default tax] = {totalWithDefaultTax:F2}");

        // Named argument for clarity; overrides default taxRate
        double totalWithCustomTax = CalculateTotal(amount: 100.0, taxRate: 0.25);
        Console.WriteLine($"CalculateTotal(100.0, taxRate: 0.25) = {totalWithCustomTax:F2}");

        // 3) Method overloading (same name, different parameters)
        Console.WriteLine($"FormatValue(42) => {FormatValue(42)}");
        Console.WriteLine($"FormatValue(3.14159) => {FormatValue(3.14159)}");
        Console.WriteLine($"FormatValue(\"Commander\") => {FormatValue("Commander")}");

        // 4) Using params to accept variable number of arguments
        int s1 = SumAll(1, 2, 3);
        int s2 = SumAll(10, 20, 30, 40, 50);
        Console.WriteLine($"SumAll(1,2,3) = {s1}");
        Console.WriteLine($"SumAll(10,20,30,40,50) = {s2}");

        // 5) ref and out parameters
        int baseValue = 5;
        // ref: must be initialized before passing; callee can modify the caller's variable
        DoubleInPlace(ref baseValue);
        Console.WriteLine($"After DoubleInPlace(ref baseValue): baseValue = {baseValue}");

        // out: callee must assign before returning; caller's variable can be uninitialized
        bool parsed = TryParsePositiveInt("123", out int parsedValue);
        Console.WriteLine($"TryParsePositiveInt(\"123\") -> parsed={parsed}, value={parsedValue}");

        bool parsedFail = TryParsePositiveInt("-9", out int parsedBad);
        Console.WriteLine($"TryParsePositiveInt(\"-9\") -> parsed={parsedFail}, value={parsedBad}");

        Console.WriteLine("=== End of Lesson 5 ===");
    }

    // Basic method: takes two ints and returns their sum
    private static int Add(int a, int b)
    {
        return a + b;
    }

    // Optional parameter: taxRate defaults to 0.20 (20%)
    private static double CalculateTotal(double amount, double taxRate = 0.20)
    {
        double tax = amount * taxRate;
        return amount + tax;
    }

    // Overloads of FormatValue: same name, different parameter types
    private static string FormatValue(int value)
    {
        return $"[int:{value}]";
    }

    private static string FormatValue(double value)
    {
        return $"[double:{value:F3}]";
    }

    private static string FormatValue(string value)
    {
        return $"[string:\"{value}\"]";
    }

    // params: allows callers to pass any number of int arguments
    private static int SumAll(params int[] numbers)
    {
        int total = 0;
        foreach (int n in numbers)
        {
            total += n;
        }
        return total;
    }

    // ref parameter: modifies the caller's variable in place
    private static void DoubleInPlace(ref int value)
    {
        value *= 2;
    }

    // out parameter: returns multiple results—bool (success) + parsed int via 'out'
    private static bool TryParsePositiveInt(string input, out int result)
    {
        // Initialize out parameter; must be assigned on all code paths before return
        result = 0;

        if (!int.TryParse(input, out int parsed))
        {
            return false;
        }

        if (parsed <= 0)
        {
            return false;
        }

        result = parsed;
        return true;
    }
}
