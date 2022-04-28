using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PIZZA.Models
{
    public class PizzaDbInitializer : DropCreateDatabaseAlways<PizzaContext>
    {
        protected override void Seed(PizzaContext db)
        {
            db.Pizzas.Add(new Pizza { Name = "Пепперони", PicFile = "Pepperoni.jpg", Description = "Cыры Моцарелла и Пармезан, шампиньоны, бекон, колбаса пепперони, помидоры, куриная грудка, чеснок, лук красный, зелень.", Price = 220 });
            db.Pizzas.Add(new Pizza { Name = "Маргарита", PicFile = "Margarita.jpg", Description = "Cыр Моцарелла, помидоры.", Price = 200 });
            db.Pizzas.Add(new Pizza { Name = "Гавайская", PicFile = "Нawaiian.jpg", Description = "Cыр Моцарелла, ветчина, ананасы.", Price = 200 });

            base.Seed(db);
        }

    }
}