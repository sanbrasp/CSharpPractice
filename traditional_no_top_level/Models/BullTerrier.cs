namespace traditional_no_top_level.Models;

public class BullTerrier : Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    
    public BullTerrier()
    {
        Species = "Bull Terrier";
        SpeciesDescription = "Clown in dog suit";
        IsPredator = true;
        HasCoat = true;
        CanBePet = true;
    }

    public override string Sound()
    {
        return $"The {Species} barks, whimpers, howls, growls, and makes food noises";
    }
    
    public override string AnimalInfo()
    {
        return $"Animal:\n" +
               $"Species: {Species}\n" +
               $"Name: {Name}\n" +
               $"Gender: {Gender}\n" +
               $"Description: {SpeciesDescription}\n" +
               $"Is predator?: {IsPredator}\n" +
               $"Has a coat?: {HasCoat}\n" +
               $"Can it be a pet?: {CanBePet}";
    }
}