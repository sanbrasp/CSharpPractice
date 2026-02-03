using traditional_no_top_level.Interface;
using traditional_no_top_level.Menu;
using traditional_no_top_level.Models;

namespace traditional_no_top_level.Tasks;

public class YoutubeTutorialInheritanceInterface : ITask, IRental
{
    public string Subject => "Inheritance VS Interface";
    public string Title => "Youtube: Tutorial";
    public string Description => "Inheritance VS Interface";
    public int Number => 1;
    
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerDay { get; set; }
    
    
    public void Run()
    {
        Console.WriteLine($"{Subject} - {Title} - {Description}");
        
    List<IRental> rentals = new List<IRental>();
    
    rentals.Add(new Truck() { CurrentRenter = "Truck Renter" });
    rentals.Add(new Sailboat { CurrentRenter = "Sailboat Renter" });
    rentals.Add(new Car { CurrentRenter = "Car Renter" });
    
    foreach (var rental in rentals)
        Console.WriteLine($"Renter: '{rental.CurrentRenter}' with rental ID: {rental.RentalId}. Price Per Day: {rental.PricePerDay}");

    RentalCar rentalcar = new RentalCar();
    rentalcar.CurrentRenter = "Mr Car Man";
    Console.WriteLine($"Rental ID: {rentalcar.RentalId} - Renter: {rentalcar.CurrentRenter}");

    }
}