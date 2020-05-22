using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class DrinkIngredientModel
    {
        public int Id { get; set; }
        public int DrinkId { get; set; }
        public int IngredientId { get; set; }
    }
}
