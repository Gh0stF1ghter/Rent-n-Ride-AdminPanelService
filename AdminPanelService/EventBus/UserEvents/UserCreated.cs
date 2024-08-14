namespace EventBus.UserEvents;

public record UserCreated(
    string Password,
    string FirstName,
    string LastName,
    string Email,
    string? PhoneNumber,
    decimal Balance,
    bool IsRenting
    );