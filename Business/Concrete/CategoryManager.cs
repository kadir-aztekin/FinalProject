using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İŞ KODLARI
            return new SuccessDataResult<List<Category>> (_categorydal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            //İŞ KODLARI
            return new SuccessDataResult<Category> (_categorydal.Get(c=>c.CategoryId == categoryId));
        }
    }
}
