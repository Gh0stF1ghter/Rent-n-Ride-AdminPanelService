using FluentValidation;

namespace AdminPanel.API.Validators;

public class ShortManufacturerViewModelValidator : AbstractValidator<ShortManufacturerViewModel>
{
    public ShortManufacturerViewModelValidator()
    {
        RuleFor(cm => cm.Name)
            .MaximumLength(30).WithMessage("Car model name length should not exceed 30 characters");
    }
}