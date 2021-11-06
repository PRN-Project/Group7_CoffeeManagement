using FluentValidation;
using Group7_CoffeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group7_CoffeeManagement.Validators
{
    public class AuthValidator : AbstractValidator<TblStaff>
    {
        public AuthValidator()
        {
            RuleFor(s => s.UserName).NotNull().NotEmpty().WithMessage("Tên tài khoản không được để trống");
            RuleFor(s => s.Password).NotNull().NotEmpty().WithMessage("Mật khẩu không được để trống");
        }
    }
}
