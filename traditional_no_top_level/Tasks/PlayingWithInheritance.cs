using System;
using traditional_no_top_level.Menu;
using traditional_no_top_level.Models;

namespace traditional_no_top_level.Tasks;

public class PlayingWithInheritance : ITask
{
    public string Subject => "Inheritance / Interface";
    public string Title => "Class - Subclass, sub-subclass - inheritance";
    public string Description => "Playing around with Animal class and inheritance";
    public int Number => 2;

    public void Run()
    {
        Console.WriteLine($"{Subject} - {Title} - {Description}");
        Console.WriteLine();
        
        //Animal animal = new Animal(); // Not allowed. Abstract class.
        Dog dog1 =  new Dog();
        Cat cat1 = new Cat();
        
        BullTerrier hjørdis = new BullTerrier();
        hjørdis.Name = "Hjørdis";
        hjørdis.Age = 6;
        hjørdis.Gender = "Female";
        hjørdis.SpeciesDescription = "She is a smol clown in a dog suit hell bent on driving her owner crazy!";
        hjørdis.CanBePet = true;
        hjørdis.IsPredator = true;

        Console.WriteLine(hjørdis.AnimalInfo());



    }
}