using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Ürün adı en fazla 50 karakter olmalıdır");

            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok miktarı boş geçilemez");
            RuleFor(x => x.Stock).GreaterThan(0).WithMessage("Stok miktarı 0'dan büyük olmalıdır");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş geçilemez");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır");
            
        }
    }
}
