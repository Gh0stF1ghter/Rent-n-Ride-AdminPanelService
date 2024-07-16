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
    }
}
