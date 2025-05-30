﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Kategori adı en az 3 karakter olmalıdır");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Kategori adı en fazla 50 karakter olmalıdır");

        }
    }
}
