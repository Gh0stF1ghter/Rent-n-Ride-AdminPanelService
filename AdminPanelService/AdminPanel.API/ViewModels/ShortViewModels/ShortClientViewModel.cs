namespace AdminPanel.API.ViewModels.ShortViewModels;

public record ShortClientViewModel(
    string FirstName,
    string LastName,
    string Email,
    string? PhoneNumber,
    decimal Balance,
    bool IsRenting
    );