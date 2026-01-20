namespace traditional_no_top_level.Menu;

public interface ITask
{
    string Subject { get; } // Subject/category
    string Title { get; }   // Short title
    string Description { get; } // Longer description
    int Number { get; } // Task number within subject
    
    void Run();             // code to execute for the task
}