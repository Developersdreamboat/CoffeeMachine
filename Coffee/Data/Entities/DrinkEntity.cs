using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Coffee
{
    public class DrinkEntity
    {
        [Key]
        public string Name { get; set; }
        public readonly IngredientEntity Composition;

        public DrinkEntity(string name, IngredientEntity composition)
        {
            Name = name;
            Composition = composition;
        }
    }
}
