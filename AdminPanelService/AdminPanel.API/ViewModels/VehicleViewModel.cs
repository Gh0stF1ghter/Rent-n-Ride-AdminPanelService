using AdminPanel.BLL.Enums;

namespace AdminPanel.API.ViewModels;

public record VehicleViewModel(
    Guid Id,
    string PlateNumber,
    int Odo,
    decimal RentCost,
    bool IsRented,
    VehicleType VehicleType,
    VehicleState VehicleState,
    FuelType FuelType,
    CarModelViewModel? Model
    );