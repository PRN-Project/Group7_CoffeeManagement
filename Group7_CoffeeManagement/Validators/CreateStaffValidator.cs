using FluentValidation;
using FluentValidation.Results;
using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Validators
{
    public class CreateStaffValidator : AbstractValidator<TblStaff>
    {
        public CreateStaffValidator()
        {
            RuleFor(s => s.UserName).NotEmpty().NotNull().Length(2, 50).Custom((value, context) =>
            {
                bool hasWhiteSpace = false;
                if (value == null)
                {
                    return;
                }
                foreach (char c in value)
                {
                    if (char.IsWhiteSpace(c))
                    {
                        hasWhiteSpace = true;
                    }
                }
                if (hasWhiteSpace)
                {
                    context.AddFailure(new ValidationFailure("username", "Can not have white space."));
                }
            });
            RuleFor(s => s.Password).NotEmpty().NotNull().Length(2, 50).Custom((value, context) =>
            {
                bool hasWhiteSpace = false;
                if (value == null)
                {
                    return;
                }
                foreach (char c in value)
                {
                    if (char.IsWhiteSpace(c))
                    {
                        hasWhiteSpace = true;
                    }
                }
                if (hasWhiteSpace)
                {
                    context.AddFailure(new ValidationFailure("password", "Can not have white space."));
                }
            }); ;
            RuleFor(s => s.Name).NotEmpty().NotNull().Length(2, 50);
        }
    }
}
