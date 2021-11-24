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

            RuleFor(p => p.Phone)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Phone Number cannot be empty!")
                .Length(11).WithMessage("Phone Number length must be 11")
                .Must(CustomValidations.ValidPhoneNumber).WithMessage("Phone Number cannot contain any character!");

            RuleFor(e => e.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Email field is empty")
                .EmailAddress().WithMessage("Invalid email address");

            RuleFor(a => a.Address)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Address cannot be empty");

            RuleFor(pass => pass.Password)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Password cannot be empty")
                .Length(8, 30).WithMessage("Password length must be between 8 to 30");

            RuleFor(sal => sal.Salary)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Salary cannot be empty")
                .Must(CustomValidations.ValidNumber).WithMessage("Salary amount contains only greater than zero numbers");

            RuleFor(t => t.UserType)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Select a User Type");

            RuleFor(status => status.Status)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Select a Status");
        }
    }
}
