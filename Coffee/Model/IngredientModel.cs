using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class IngredientModel
    {
        public int Id { get; set; }
        private int _coffee;
        private int _milk;
        private int _water;


        public IngredientModel(int coffee, int milk, int water)
        {
            Coffee = coffee;
            Milk = milk;
            Water = water;
        }

        public IngredientModel()
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

        public IngredientModel Sub(IngredientModel b)
        {
            var sec = b as IngredientModel;
            var res = new IngredientModel();
            res.Coffee = Coffee - sec.Coffee;
            res.Milk = Milk - sec.Milk;
            res.Water = Water - sec.Water;
            return res;
        }
        public static IngredientModel operator +(IngredientModel c1, IngredientModel c2)
        { IngredientModel res = new IngredientModel();

            res.Milk = c1.Milk + c2.Milk;
            res.Water = c1.Water + c2.Water;
            res.Coffee = c1.Coffee + c2.Coffee;
            return res;
        }
        public static IngredientModel operator /(IngredientModel c1, IngredientModel c2)
        {
            IngredientModel res = new IngredientModel();

            res.Milk = c1.Milk / c2.Milk;
            res.Water = c1.Water / c2.Water;
            res.Coffee = c1.Coffee / c2.Coffee;
            return res;
        }
        public IngredientModel Multiply(int times) 
        {
            var res = new IngredientModel();
            res.Coffee = Coffee * times;
            res.Milk = Milk * times;
            res.Water = Water * times;
            return res;
        }
    }
}
