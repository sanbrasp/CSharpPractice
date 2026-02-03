namespace traditional_no_top_level.Models;

public class Bicycle : Vehicle
{
    public int Speed = 0;

    public void Go()
    {
        Console.WriteLine("Vehicle bicycle going...");
    }
}