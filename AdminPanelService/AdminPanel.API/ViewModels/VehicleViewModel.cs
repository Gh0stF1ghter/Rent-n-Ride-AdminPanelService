﻿using AdminPanel.BLL.Enums;

namespace AdminPanel.API.ViewModels;

public record VehicleViewModel(
    Guid Id,
    string PlateNumber,
    int Odo,
    decimal RentCost,
    bool IsRented,
    VehicleType VehicleType = VehicleType.None,
    VehicleState VehicleState = VehicleState.None,
    FuelType FuelType = FuelType.None,
    CarModelViewModel? CarModel
    );