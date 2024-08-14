namespace EventBus.UserEvents;

public record UserUpdated(
    Guid Id,
    decimal Balance,
    bool IsRenting
    );