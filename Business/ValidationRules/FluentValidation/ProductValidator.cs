using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator :AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün ismi boş geçilemez");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez");
            RuleFor(x => x.UnitPrice).GreaterThan(0).WithMessage("Ürün Fiyatı sıfırdan büyük olmalıdır.");
            RuleFor(x => x.UnitsInStock).NotEmpty().WithMessage("Ürün stok alanı boş geçilemez.");
            RuleFor(x => x.ProductName).MaximumLength(40).WithMessage("Lütfen ürün ismini 40 karakterden fazla girmeyiniz.");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Lütfen ürün ismini en az 2 karakter giriniz.");
           // RuleFor(x => x.ProductName).Must(StartWithA);
        }

        public bool StartWithA(string parameter)
        {
            return parameter.StartsWith("A");
        }
    }
}
