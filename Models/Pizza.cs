using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIZZA.Models
{
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        public string Name { get; set; }
        public string PicFile { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}