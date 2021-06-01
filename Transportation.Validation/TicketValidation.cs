using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Transportation.Entity;

namespace Transportation.Validation
{
    public class TicketValidation : AbstractValidator<Ticket>
    {
        public TicketValidation()
        {
            RuleFor(t => t.CustomerName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Name field is empty")
                .Length(2, 50).WithMessage("Name Length must be between 2 to 50")
                .Must(CustomValidations.ValidName).WithMessage("Name contains invalid characters");

            RuleFor(t => t.CustomerPhone)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Phone Number cannot be empty!")
                .Length(8, 15).WithMessage("Phone Number length must be between 8 to 15")
                .Must(CustomValidations.ValidPhoneNumber).WithMessage("Phone Number cannot contain any character!");
        }
    }
}
