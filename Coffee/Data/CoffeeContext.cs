using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Coffee
{
    public class CoffeeContext : DbContext
    {
        public DbSet<AutomatEntity> Automats { get; set; }
        public DbSet<DrinkEntity> Drinks { get; set; }
        public DbSet<IngredientEntity> Ingredients { get; set; }
        public DbSet<AutomatIngredientEntity> AutomatIngredients { get; set; }
        public DbSet<AutomatOrderEntity> AutomatOrders { get; set; }
        public DbSet<DrinkIngredientEntity> DrinkIngredients { get; set; }
        public CoffeeContext() : base("name=CoffeeContext")
        {
            Database.CreateIfNotExists();
        }

    }
}
