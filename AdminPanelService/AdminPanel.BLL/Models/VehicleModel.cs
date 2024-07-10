using AdminPanel.BLL.Enums;

namespace AdminPanel.BLL.Models;

public class VehicleModel
{
    public Guid Id { get; set; }

    public string PlateNumber { get; set; } = string.Empty;
    public int Odo { get; set; }
    public decimal RentCost { get; set; }
    public bool IsRented { get; set; }

    public VehicleType VehicleType { get; set; }
    public VehicleState VehicleState { get; set; }
    public FuelType FuelType { get; set; }

    public Guid ModelId { get; set; }
    public CarModel? Model { get; set; }
}