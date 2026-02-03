using System;
using traditional_no_top_level.Menu;

namespace traditional_no_top_level.Tasks;

public class TestTask : ITask
{
    public string Subject => "Test";
    public string Title => "Test";
    public string Description => "Testing task template";
    public int Number => 1;

    public void Run()
    {
        Console.WriteLine($"{Subject} - {Title} - {Description}");
        Console.WriteLine("I created a task template that does all of the above\n" +
                          "(sans actually writing the strings) for me. Very handy.");
    }
}