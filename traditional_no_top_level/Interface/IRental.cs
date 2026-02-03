namespace traditional_no_top_level.Interface;

public interface IRental
{
    int RentalId { get; set; }
    string CurrentRenter { get; set; }
    decimal PricePerDay { get; set; }
}