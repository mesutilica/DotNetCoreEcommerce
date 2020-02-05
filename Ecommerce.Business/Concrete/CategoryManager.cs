using DotNetCoreEcommerce.Northwind.Entities.Concrete;
using Ecommerce.Business.Abstract;
using Ecommerce.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
