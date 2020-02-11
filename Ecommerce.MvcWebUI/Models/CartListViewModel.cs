using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Ecommerce.MvcWebUI.Models
{
    public class CartListViewModel
    {
        public Cart Cart { get; internal set; }
    }
}
