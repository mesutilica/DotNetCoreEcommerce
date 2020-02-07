using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Business.Abstract;
using Ecommerce.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;
        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }
        public IActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            TempData.Add("message", string.Format("{0} Ürünü Sepetinize Eklenmiştir!", productToBeAdded.ProductName));
            return RedirectToAction("Index", "Product");
        }
    }
}