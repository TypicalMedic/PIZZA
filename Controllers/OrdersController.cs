using PIZZA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIZZA.Controllers
{
    public class OrdersController : Controller
    {
        PizzaContext db = new PizzaContext();
        // GET: Orders
        public ActionResult Index()
        {
            return View(new OrderViewModel {orders = db.Orders.ToList(), orderPositions = db.OrderPositions.ToList(), Pizzas = db.Pizzas.ToList() });
        }
    }
}