namespace traditional_no_top_level.Models;

public class Dog : Mammal
{
    public Dog()
    {
        Species = "Dog";
        SpeciesDescription = "Four-legged being made of love and mischeif";
        IsPredator = true;
        HasCoat = true;
        CanBePet = true;
    }

    public override string Sound()
    {
        return $"{Species} barks!";
    }

    public override string Eat()
    {
        return $"{Species} eats mostly meat, but can also have some vegetables and berries.";
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