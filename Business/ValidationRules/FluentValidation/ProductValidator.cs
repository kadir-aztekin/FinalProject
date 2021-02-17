using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        //PRODUCT KURALLARI 
        public ProductValidator()
        {
            //NotEmpty:Bos olamaz
            //GreaterThan: Den buyuk demek
            //GreaterThanOrEqualto : dan buyuk eşit demek 
            //Must :Uymalı

            RuleFor(p => p.ProductName).NotEmpty(); 
            RuleFor(p=>p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0); //0 dan buyuk olmalı 
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1); //
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");


        }

        private bool StartWithA(string arg) //Dikkat et bool 
        {
            return arg.StartsWith("A"); //A bile baslıyor mu 
        }
    }
}
