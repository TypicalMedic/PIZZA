using PIZZA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PIZZA.Controllers
{
    public class CartController : Controller
    {
        PizzaContext db = new PizzaContext();

        public ViewResult Index(string mes)
        {
            ViewBag.Message = mes;
            return View(new CartIndexViewModel
            {
                Cart = GetCart()
            });
        }

        public RedirectToRouteResult AddToCart(int productId, string returnUrl)
        {
            Pizza pizza = db.Pizzas.FirstOrDefault(p => p.PizzaId == productId);
            if (pizza != null)
            {
                GetCart().AddItem(pizza, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        [HttpPost]
        public RedirectToRouteResult MakeOrder()
        {
            db.Orders.Add(new Order { date = DateTime.Now.Date});
            db.SaveChanges();
            int orderId = db.Orders.Select(c => c.Id).Max();
            foreach(var x in GetCart().Lines)
            {
                db.OrderPositions.Add(new orderPosition { orderid = orderId, pizzaid = x.Product.PizzaId, quantity = x.Quantity });
            }
            db.SaveChanges();
            GetCart().Clear();
            string mes ="Заказ оформлен!";
            return RedirectToAction("Index", new {mes});
        }

        public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
        {
            Pizza pizza = db.Pizzas.FirstOrDefault(p => p.PizzaId == productId);
            if (pizza != null)
            {
                GetCart().RemoveLine(pizza);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

    }
}