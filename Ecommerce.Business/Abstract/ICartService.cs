using Ecommerce.Entities.Concrete;
using Entities.Concrete;
using System.Collections.Generic;

namespace Ecommerce.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
