using Core.DataAccess;
using Entitie.DTOS;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
// CODE REFACTORİNG : KODUN İYİLEŞTİRİLMESİ DENİR 