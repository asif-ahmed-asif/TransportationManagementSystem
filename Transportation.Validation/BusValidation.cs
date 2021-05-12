using FluentValidation;
using Transportation.Entity;

namespace Transportation.Validation
{
    public class BusValidation : AbstractValidator<Bus>
    {
        public BusValidation()
        {
            RuleFor(b => b.BusNo)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Bus Number is required!")
                .Length(2, 50).WithMessage("Bus Number Length must be between 2 to 50 characters");
            
            RuleFor(t => t.TypeId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Select a Bus Type!");
        }
    }
}