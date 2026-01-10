using System;

namespace traditional_no_top_level;

internal class Program
{
    static void Main(string[] args)
    {
        // Choose lesson via args (1 - 5) or hardcode selection
        Console.WriteLine("Choose lesson: 1 or 5 (Traditional C#)");
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
            
            case "4":
                Lesson4.Run();
                break;
            
            case "5":
                Lesson5.Run();
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}