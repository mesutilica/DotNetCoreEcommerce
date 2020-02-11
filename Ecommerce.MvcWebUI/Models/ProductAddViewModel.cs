using System.Collections.Generic;
using Ecommerce.Entities.Concrete;

namespace Ecommerce.MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public List<Category> Categories { get; internal set; }
        public Product Product { get; set; }
    }
}
