using PIZZA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIZZA.Models
{
    public class CartLine
    {
        public Pizza Product { get; set; }
        public int Quantity { get; set; }
    }
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
    }
}
