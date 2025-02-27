﻿namespace AdminPanel.API.ViewModels;

public record VehicleClientHistoryViewModel(
    Guid Id,
    DateTime StartDate,
    DateTime EndDate,
    Guid VehicleId,
    Guid ClientId
    );