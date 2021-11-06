using FluentValidation;
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
            RuleFor(s => s.UserName).NotEmpty().NotNull().Length(2, 50);
            RuleFor(s => s.Password).NotEmpty().NotNull().Length(2, 50);
            RuleFor(s => s.Name).NotEmpty().NotNull().Length(2, 50);
        }
    }
}
