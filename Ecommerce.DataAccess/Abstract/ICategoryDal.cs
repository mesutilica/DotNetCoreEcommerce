using Core.DataAccess;
using DotNetCoreEcommerce.Northwind.Entities.Concrete;

namespace Ecommerce.DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
    }
}
