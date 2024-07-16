namespace AdminPanel.API.ViewModels;

public record CarModelViewModel(
    Guid Id,
    string Name,
    ManufacturerViewModel? Manufacturer,
    IEnumerable<VehicleViewModel> Vehicles
    );