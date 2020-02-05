using Core.DataAccess;
using Ecommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
    }
}
