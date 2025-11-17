using eCommerce.Core.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Core.Validators
{
    public class RegisterValidator:AbstractValidator<RegisterRequest>
    {
        public RegisterValidator()
        { 
           RuleFor(tem=>tem.Email).NotEmpty().WithMessage("Email is requred")
                .EmailAddress().WithMessage("Invalid email address format");

            RuleFor(tem=>tem.Password).NotEmpty()
                .WithMessage("Password is required")
                .MinimumLength(6)
                .WithMessage("Password must be at least 6 characters long");

            RuleFor(tem => tem.PersonName).NotEmpty().WithMessage("Person Name is required");

            RuleFor(tem => tem.Gender).IsInEnum().WithMessage("Invalid gender option");
        }
    }
}
