using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Coffee
{
    public class AutomatIngredientRepository:Repository<AutomatIngredientEntity>,IAutomatIngredientRepository
    {
        public AutomatIngredientRepository(DbContext context) : base(context)
        {
        }
    }
}
