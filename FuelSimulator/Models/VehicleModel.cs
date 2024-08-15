namespace FuelSimulator.Models;

public class VehicleModel
{
    public int Id { get; set; }
    public required string Model { get; set; }
    public required string Plate { get; set; }
    public required float Velocity { get; set; }
    public required float Performance { get; set; }
    public required float Tank { get; set; }
    public string? Route { get; set; }
    public string? LinkImage { get; set; }
}

