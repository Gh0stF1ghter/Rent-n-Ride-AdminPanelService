namespace AdminPanel.API.ViewModels;

public record ManufacturerViewModel(
    Guid Id,
    string Name,
    IEnumerable<CarModelViewModel> ModelNames
    );