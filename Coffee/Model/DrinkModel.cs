using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class DrinkModel
    {
        public readonly IngredientModel Composition;

        public DrinkModel(int id, IngredientModel composition)
        {
            this.id=id;
            Composition = composition;
        }

        public int id { get; }
    }
}
