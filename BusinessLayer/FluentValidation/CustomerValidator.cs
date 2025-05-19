using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("İsim en az 2 karakter olmalıdır");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("İsim en fazla 50 karakter olmalıdır");
        }
    }
}
