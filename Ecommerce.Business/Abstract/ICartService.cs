using DotNetCoreEcommerce.Northwind.Entities.Concrete;
using Ecommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
