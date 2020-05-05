using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee
{
    public class IngredientEntity
    {
        [Key]
        public int Id { get; set; }
        private int _coffee;
        private int _milk;
        private int _water;
        public virtual AutomatEntity AutomatEntity { get; set; }
        public IngredientEntity(int coffee, int milk, int water)
        {
            Coffee = coffee;
            Milk = milk;
            Water = water;
        }

        public IngredientEntity()
        {
        }
        public int Coffee
        {
            get => _coffee;
            set
            {
                if (value >= 0) _coffee = value;
                else throw new ArgumentOutOfRangeException("Value must be greater or equals to zero");
            }
        }

        public int Milk
        {
            get => _milk;
            set
            {
                if (value >= 0) _milk = value;
                else throw new ArgumentOutOfRangeException("Value must be greater or equals to zero");
            }
        }

        public int Water
        {
            get => _water;
            set
            {
                if (value >= 0) _water = value;
                else throw new ArgumentOutOfRangeException("Value must be greater or equals to zero");
            }
        }
    }
}
