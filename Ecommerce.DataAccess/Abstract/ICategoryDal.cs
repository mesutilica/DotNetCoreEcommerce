using Core.DataAccess;
using Ecommerce.Entities.Concrete;

namespace Ecommerce.DataAccess.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category>
    {
    }
}
