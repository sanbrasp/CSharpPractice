namespace traditional_no_top_level.Models;

public class Cat : Mammal
{
    public bool IsSassy { get; set; }
    
    public Cat()
    {
        Species = "Cat";
        SpeciesDescription = "Four-legged, sometimes fluffy, drill sergeant.";
        IsPredator = true;
        HasCoat = true;
        CanBePet = true;
        IsSassy = true;
    }

    public override string Sound()
    {
        return $"{Species} meows, purrs, screams, whines, and snores.";
    }

    public override string Eat()
    {
        return $"{Species} eats a meat diet (but some eat lasagna).";
    }
    
    public override string AnimalInfo()
    {
        return $"Animal:\n" +
               $"Species: {Species}\n" +
               $"Description: {SpeciesDescription}\n" +
               $"Is predator?: {IsPredator}\n" +
               $"Has a coat?: {HasCoat}\n" +
               $"Can it be a pet?: {CanBePet}";
    }
}