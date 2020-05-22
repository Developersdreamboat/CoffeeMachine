using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Coffee.Data.Repositories
{
    public class DrinkIngredientRepository:Repository<DrinkIngredientEntity>,IDrinkIngredientRepository
    {
        public DrinkIngredientRepository(DbContext context) : base(context)
        {
        }
    }
}
