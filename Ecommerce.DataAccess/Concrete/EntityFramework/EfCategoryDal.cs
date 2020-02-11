using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Ecommerce.DataAccess.Abstract;
using Ecommerce.Entities.Concrete;

namespace Ecommerce.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
