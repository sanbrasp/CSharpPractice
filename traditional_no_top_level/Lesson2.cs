namespace traditional_no_top_level;

public static class Lesson2
{
    public static void Run()
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