namespace traditional_no_top_level.Models;

public abstract class Mammal
{
    public string Species { get; set; }
    public string SpeciesDescription { get; set; }
    public bool IsPredator { get; set; }
    public bool HasCoat { get; set; }
    public bool CanBePet { get; set; }
    
    public abstract string AnimalInfo();

    public abstract string Sound();

    public abstract string Eat();
}