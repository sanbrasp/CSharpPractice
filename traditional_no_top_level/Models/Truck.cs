using traditional_no_top_level.Interface;

namespace traditional_no_top_level.Models;

public class Truck : LandVehicle, IRental
{
    public int RentalId { get; set; }
    public string CurrentRenter { get; set; }
    public decimal PricePerDay { get; set; }
}