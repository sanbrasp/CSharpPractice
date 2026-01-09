// Lesson 1: Top level (only one file in the project should contain top-level statements)
// All the magic happens behind the scenes, but it does the same operations as the traditional method.
// Code is not wrapped in a class and main, but in the background it is.


Console.WriteLine("Choose lesson: 1 - 6");
var choice = Console.ReadLine();

switch (choice)
{
    case "1": Lesson1.Run(); break;
    case "2": Lesson2.Run(); break;
    // case "3": Lesson3.Run(); break;
    // case "4": Lesson4.Run(); break;
    // case "5": Lesson5.Run(); break;
    // case "6": await Lesson5.RunAsync(); break; // if async
    default: Console.WriteLine("Invalid choice"); break;
}