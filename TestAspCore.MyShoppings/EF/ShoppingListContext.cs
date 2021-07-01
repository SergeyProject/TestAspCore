using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAspCore.MyShoppings.Models;

namespace TestAspCore.MyShoppings.EF
{
    public class ShoppingListContext:DbContext
    {
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public ShoppingListContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=ProductsContext;Trusted_Connection=True");
        }
    }
}
