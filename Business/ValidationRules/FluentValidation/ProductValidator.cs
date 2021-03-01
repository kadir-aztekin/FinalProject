using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).MinimumLength(2); //Product ıcın minimum boyutu 2 olmalıdır
            RuleFor(p => p.ProductName).NotEmpty(); //Boş Olamaz
            RuleFor(p => p.UnitPrice).NotEmpty(); //Boş Olamaz
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A ile Başlamalı");

        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");

        }
    }
}