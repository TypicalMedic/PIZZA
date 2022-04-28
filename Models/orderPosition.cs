using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIZZA.Models
{
    public class orderPosition
    {
        public int orderid { get; set; }
        public int pizzaid { get; set; }
        public int quantity { get; set; }
    }
}