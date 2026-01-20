
// MenuService.cs
// Purpose:
// - Discover all ITask implementations in the current assembly.
// - Show a console menu where you pick a Subject by number,
//   then pick a Task (by its Number inside that subject), and run it.

using System.Reflection;
// Note: System.Linq is typically available via implicit usings in modern .NET SDKs.
// If you disabled implicit usings, uncomment the next line:
// using System.Linq;

namespace traditional_no_top_level.Menu;

public class MenuService
{
    // Holds all discovered tasks for the lifetime of the menu.
    private readonly List<ITask> _tasks;

    public MenuService()
    {
        // Discover concrete ITask implementations once at startup.
        _tasks = DiscoverTasks();
    }

    public void ShowMainLoop()
    {
        // Main loop: simple single-screen menu.
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Menu ===");
            Console.WriteLine("1) Choose subject and task");
            Console.WriteLine("Enter) Exit");
            Console.Write("\nYour choice: ");

            // Read a single key without echoing it to the line.
            var key = Console.ReadKey(intercept: true).Key;

            // Enter exits the app.
            if (key == ConsoleKey.Enter)
                return;

            // Pressing 1 runs the subject/task selection workflow.
            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {
                RunBySubjectAndTask();
            }
        }
    }

    // Shows subjects as a numbered list, lets you pick one,
    // then lists tasks inside that subject and runs the chosen task.
    private void RunBySubjectAndTask()
    {
        Console.Clear();

        // Build a list of unique subjects from all tasks, sorted alphabetically.
        // Distinct() uses default string equality (case-sensitive).
        var subjects = _tasks
            .Select(t => t.Subject)
            .Distinct()
            .OrderBy(s => s)
            .ToList();

        // If there are no subjects at all, let the user know and return to main menu.
        if (subjects.Count == 0)
        {
            Console.WriteLine("No subjects found. Add tasks that implement ITask.");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey(true);
            return;
        }

        // Show subjects as a numbered list (1..N) to allow numeric selection.
        Console.WriteLine("Available subjects:");
        for (int i = 0; i < subjects.Count; i++)
            Console.WriteLine($"{i + 1}) {subjects[i]}");

        // Optional: Back option; choose 0 to return to main menu.
        Console.WriteLine("0) Back");
        Console.Write("\nSelect subject number: ");

        // Read the user's input for subject index and parse it into an integer.
        if (!int.TryParse(Console.ReadLine(), out var subjectIndex))
        {
            Console.WriteLine("Invalid input. Press any key to continue...");
            Console.ReadKey(true);
            return;
        }

        // If user chose 0, go back to main menu.
        if (subjectIndex == 0)
            return;

        // Convert human-friendly 1-based choice to 0-based index and validate bounds.
        subjectIndex -= 1;
        if (subjectIndex < 0 || subjectIndex >= subjects.Count)
        {
            Console.WriteLine("Subject number out of range. Press any key to continue...");
            Console.ReadKey(true);
            return;
        }

        // Grab the chosen subject string directly from the list to avoid typos/casing issues.
        var subjectChoice = subjects[subjectIndex];

        // Filter tasks that match the chosen subject and order them by Number (your chosen sort key).
        var selectedTasks = _tasks
            .Where(t => t.Subject == subjectChoice)
            .OrderBy(t => t.Number)
            .ToList();

        // If a subject exists but has no tasks, inform and return.
        if (selectedTasks.Count == 0)
        {
            Console.Clear();
            Console.WriteLine($"Subject \"{subjectChoice}\" has no tasks yet.");
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey(true);
            return;
        }

        // List available tasks for the chosen subject as "Number) Title".
        Console.Clear();
        Console.WriteLine($"Subject: {subjectChoice} — tasks:");
        foreach (var t in selectedTasks)
            Console.WriteLine($"{t.Number}) {t.Title}");

        Console.Write("\nSelect task number: ");

        // Read the task number (this must match the task's own Number property).
        if (!int.TryParse(Console.ReadLine(), out var number))
        {
            Console.WriteLine("Invalid number. Press any key to continue...");
            Console.ReadKey(true);
            return;
        }

        // Find the first task in the subject with the requested Number.
        var task = selectedTasks.FirstOrDefault(t => t.Number == number);
        if (task is null)
        {
            Console.WriteLine("Task not found. Press any key to continue...");
            Console.ReadKey(true);
            return;
        }

        // Show what is about to run, print Description for context, then run the task itself.
        Console.Clear();
        Console.WriteLine($"Running: {task.Subject}, Task {task.Number} — {task.Title}\n");
        Console.WriteLine(task.Description + "\n");

        task.Run();

        Console.WriteLine("\nDone. Press any key to return to the menu...");
        Console.ReadKey(true);
    }

    // Reflects over the current assembly to find all non-abstract, non-interface types
    // that implement ITask and have a public parameterless constructor.
    // Those types are instantiated and returned as a list.
    private static List<ITask> DiscoverTasks()
    {
        var assembly = Assembly.GetExecutingAssembly();

        return assembly
            .GetTypes()
            .Where(t =>
                typeof(ITask).IsAssignableFrom(t) &&        // must implement ITask (directly or via inheritance)
                t is { IsAbstract: false, IsInterface: false } && // must be a concrete class
                t.GetConstructor(Type.EmptyTypes) != null)  // must have a public parameterless ctor
            .Select(t => (ITask)Activator.CreateInstance(t)!) // create an instance we can call Run() on
            .ToList();
    }
}
