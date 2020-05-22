using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Coffee
{
    public class IngredientRepository:Repository<IngredientEntity>,IIngredientRepository
    {
        public IngredientRepository(DbContext context) : base(context)
        {
        }
    }
}
