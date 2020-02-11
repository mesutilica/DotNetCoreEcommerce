using Ecommerce.Entities.Concrete;
using System.Collections.Generic;

namespace Ecommerce.MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
