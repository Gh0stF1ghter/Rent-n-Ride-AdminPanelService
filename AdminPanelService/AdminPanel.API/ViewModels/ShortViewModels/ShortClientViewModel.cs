namespace AdminPanel.API.ViewModels.ShortViewModels;

public record ShortClientViewModel(
    string Password,
    string FirstName,
    string LastName,
    string Email,
    string? PhoneNumber,
    decimal Balance,
    bool IsRenting
    );