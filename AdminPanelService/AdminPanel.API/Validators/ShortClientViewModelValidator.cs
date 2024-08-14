using FluentValidation;

namespace AdminPanel.API.Validators;

public class ShortClientViewModelValidator : AbstractValidator<ShortClientViewModel>
{
    public ShortClientViewModelValidator()
    {
        RuleFor(c => c.FirstName)
            .MaximumLength(20);

        RuleFor(c => c.LastName)
            .MaximumLength(20);

        RuleFor(c => c.Email)
            .EmailAddress();

        RuleFor(c => c.Password)
            .MinimumLength(8)
            .MaximumLength(20)
            .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]*$")
            .WithMessage("Weak password. Check for one lowercase, one uppercase, one special character and digit");
    }
}
