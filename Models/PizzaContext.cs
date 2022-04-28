using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PIZZA.Models
{
    public class PizzaContext: DbContext    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<orderPosition>()
                .HasKey(c => new { c.orderid, c.pizzaid });
        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<orderPosition> OrderPositions { get; set; }
    }
}