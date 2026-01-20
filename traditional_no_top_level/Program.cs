using System.Text;
using traditional_no_top_level.Menu;

namespace traditional_no_top_level;

public static class Program
{
    static void Main(string[] args)
    {
        // Make console output looks nice and handle Unicode
        Console.Title = "C# Practice - Subject Menu";
        Console.OutputEncoding = Encoding.UTF8;
        
        // Global safety net for unexpected crashes
        AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nAn unexpected error occurred: ");
            Console.ResetColor();
            Console.WriteLine(e.ExceptionObject?.ToString() ?? "(no exceptoin info");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
        };
        
        // Start the menu loop that discovers ITask implements and runs them
        var menu = new MenuService();
        menu.ShowMainLoop();
    }
}