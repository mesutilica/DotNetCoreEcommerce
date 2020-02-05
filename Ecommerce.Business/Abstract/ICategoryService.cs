using DotNetCoreEcommerce.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Ecommerce.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
