using Core.DataAccess.EntityFramework;
using DotNetCoreEcommerce.Northwind.Entities.Concrete;
using Ecommerce.DataAccess.Abstract;

namespace Ecommerce.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
