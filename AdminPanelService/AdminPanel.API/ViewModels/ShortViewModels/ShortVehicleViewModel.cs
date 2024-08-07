using AdminPanel.BLL.Enums;

namespace AdminPanel.API.ViewModels.ShortViewModels;

public record ShortVehicleViewModel(
    Guid? CarModelId,
    string PlateNumber,
    decimal RentCost,
    int Odo,
    bool IsRented,
    VehicleType VehicleType = VehicleType.None,
    VehicleState VehicleState = VehicleState.None,
    FuelType FuelType = FuelType.None
    );