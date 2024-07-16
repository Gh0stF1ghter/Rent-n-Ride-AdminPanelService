using FluentValidation;

namespace AdminPanel.API.Validators;

public class ShortCarModelViewModelValidator : AbstractValidator<ShortCarModelViewModel>
{
    public ShortCarModelViewModelValidator()
    {
        RuleFor(cm => cm.Name)
            .MaximumLength(30).WithMessage("Car model name length should not exceed 30 characters");
    }
}