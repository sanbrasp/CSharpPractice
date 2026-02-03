using traditional_no_top_level.Enum;

namespace traditional_no_top_level.Models;

public class RentalCar : RentalVehicle
{
    public CarType Style { get; set; }
    public int Weight { get; set; }
}