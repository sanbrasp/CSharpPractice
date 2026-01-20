using traditional_no_top_level.Menu;

namespace traditional_no_top_level;

public class ReverseString : ITask
{
    public string Title => "Reverse String";
    public string Description => "Reads a string from console and prints the reverse.";
    public string Subject => "Strings";
    public int Number => 2;
    
    public void Run()
    {
        Console.WriteLine("Write some text: ");
        var input = Console.ReadLine() ?? string.Empty;
        
        var reversed = new String(input.Reverse().ToArray());
        Console.WriteLine("Reversed: " + reversed);
    }
}