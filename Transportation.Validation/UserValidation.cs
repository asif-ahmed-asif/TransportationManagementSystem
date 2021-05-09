using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Transportation.Entity;

namespace Transportation.Validation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Name field is empty")
                .Length(2, 50).WithMessage("Name Length must be between 2 to 50")
                .Must(CustomValidations.ValidName).WithMessage("Name contains invalid characters");

            RuleFor(e => e.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Email field is empty")
                .EmailAddress().WithMessage("Invalid email address");
        }
    }
}
