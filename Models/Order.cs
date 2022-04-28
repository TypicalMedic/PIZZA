using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIZZA.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime date { get; set; }
    }
    public class OrderViewModel
    {
        public IEnumerable<Order> orders{ get; set; }
        public IEnumerable<orderPosition> orderPositions{ get; set; }
        public IEnumerable<Pizza> Pizzas { get; set; }
        public decimal TotalPrice(int order)
        {
            decimal sum = 0;
            var piz = orderPositions.Where(c => c.orderid == order);
            foreach(var x in piz)
            {
                sum += x.quantity * Pizzas.FirstOrDefault(p => p.PizzaId == x.pizzaid).Price;
            }
            return sum;
        }
    }
}