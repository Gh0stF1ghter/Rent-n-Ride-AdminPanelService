namespace EventBus;

public record UserUpdated(
    Guid Id,
    string FirstName,
    string LastName,
    bool IsRenting
    );