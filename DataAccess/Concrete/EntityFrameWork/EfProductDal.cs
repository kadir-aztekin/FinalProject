﻿using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entitie.DTOS;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    //NUGET 

    //EFENTİTYREPOSİTORY > IPRODUTCTDAL>EFPRODUCTDAL YANİ HEPSİNİ EFENTİTYREPOSİTORY İÇİNDE VAR 
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto 
                             {ProductId=p.ProductId,ProductName=p.ProductName,CategoryName=c.CategoryName,UnitInStock=p.UnitsInStock };
                return result.ToList();
            }
            
        }
    }
}
