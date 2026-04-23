namespace Cars.Domain;

public class Car
{
    public int Id { get; set; } // PK

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
    public bool IsActive { get; set; } = true; 
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}