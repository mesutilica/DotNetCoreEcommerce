using System.Collections.Generic;
using Ecommerce.Entities.Concrete;

namespace Ecommerce.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}
