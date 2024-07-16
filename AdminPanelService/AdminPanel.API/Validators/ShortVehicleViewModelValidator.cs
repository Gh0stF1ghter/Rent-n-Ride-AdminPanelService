using FluentValidation;

namespace AdminPanel.API.Validators;

public class ShortVehicleViewModelValidator : AbstractValidator<ShortVehicleViewModel>
{
    public ShortVehicleViewModelValidator()
    {
        RuleFor(v => v.ModelId)
            .NotEmpty().WithMessage("Car model should have a manufacturer");

        RuleFor(v => v.Odo)
            .GreaterThanOrEqualTo(0);

        RuleFor(v => v.RentCost)
            .GreaterThanOrEqualTo(0);
    }
}