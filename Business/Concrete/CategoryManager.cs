using Business.Abstract;
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

        public List<Category> GetAll()
        {
            //İŞ KODLARI
            return _categorydal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            //İŞ KODLARI
            return _categorydal.Get(c=>c.CategoryId == categoryId);
        }
    }
}
