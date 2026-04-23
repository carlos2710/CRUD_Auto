namespace Cars.Web.Models;


public class CarDto
{
    public int Id { get; set; }

    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Year { get; set; }

    public string VehicleType { get; set; } = string.Empty;
    public int Seats { get; set; }

    public string Color { get; set; } = string.Empty;

    public string? FuelType { get; set; }
    public string? Transmission { get; set; }

    public int? EngineCapacityCc { get; set; }
    public decimal? Price { get; set; }

    public bool IsActive { get; set; }
}