using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class AutomatIngredientEntity
    {
        public int Id { get; set; }
        public int AutomatId { get; set; }
        public int IngredientId { get; set; }
        public int MaxIngredients { get; set; }
        public int CurrentIngredients { get; set; }
    }
}
