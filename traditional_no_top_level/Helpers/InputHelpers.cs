namespace traditional_no_top_level.Helpers;
// Helpers from 'ukesoppgaver'

public class InputHelpers
{
    // Wait for Enter
    public static void Wait()
    {
        Console.WriteLine();
        Console.Write("Press Enter to return to the menu...");
        Console.ReadLine();
    }

    // Simple math helper
    public static double Sum(double a, double b) => a + b;

    // Read an int safely
    public static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            if (int.TryParse(s, out var value))
                return value;

            Console.WriteLine("Invalid input. Please enter a whole number (e.g., -12, 0, 42).");
        }
    }

    // Read a double safely
    public static double ReadDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? s = Console.ReadLine();
            if (double.TryParse(s, out var value))
                return value;

            Console.WriteLine("Invalid input. Please enter a number (e.g., -2.5, 0, 3.14).");
        }
    }
}