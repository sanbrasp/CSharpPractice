using traditional_no_top_level.Menu;
using traditional_no_top_level.Models;

namespace traditional_no_top_level.Tasks;

public class BuildAPerson : ITask
{
    public string Subject => "Classes";
    public string Title => "Create a Person";
    public string Description => "Create a person from the Person Class.";
    public int Number => 2;

    public void Run()
    {
        Person p1 = new Person("John", "Doe", 1987);

        Console.WriteLine(p1.ShowFullName());
        Console.WriteLine(p1.GetBirthYear());
        Console.WriteLine(p1.IsPersonAlive());
        p1.PersonIsDead();
        Console.WriteLine(p1.IsPersonAlive());
    }
}