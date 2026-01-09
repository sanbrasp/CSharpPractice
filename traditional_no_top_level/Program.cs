using System;

namespace traditional_no_top_level;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose lesson: 1 or 3 (Traditional)");
        Console.Write("Enter a choice: ");
        var choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Lesson1.Run();
                break;

            case "2":
                Lesson2.Run();
                break;
            
            case "3":
                Lesson3.Run();
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}