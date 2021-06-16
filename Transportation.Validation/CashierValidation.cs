using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Transportation.Entity;

namespace Transportation.Validation
{
    public class CashierValidation : AbstractValidator<Ticket>
    {
        public CashierValidation()
        {

            RuleFor(t => t.DeptLocation)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Departure Location is required!");

            RuleFor(t => t.Destination)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Destination is required!");

            RuleFor(t => t.BusType)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("Select a Bus Type");

        }

    }
}
