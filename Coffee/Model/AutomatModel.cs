using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class AutomatModel
    {
        public List<KeyValuePair<DrinkModel,int>> history = new List<KeyValuePair<DrinkModel,int>>();
        public readonly IngredientModel MaxIngredients;
        private IngredientModel _curreentIngredients;
        public int Id { get; set; }
        private int usedCapuccino;
        private int usedLatte;
        private int usedMocha;
        public AutomatModel() { }
        public AutomatModel(string name, IngredientModel maxIngredients)
        {
            Name = name;
            MaxIngredients = maxIngredients;
            _curreentIngredients = maxIngredients;
        }
        public int UsedCapuccino
        {
            get => usedCapuccino;
            set
            {
                usedCapuccino = value;
            }
        }
        public int UsedLatte
        {
            get => usedLatte;
            set
            {
                usedLatte = value;
            }
        }
        public int UsedMocha
        {
            get => usedMocha;
            set
            {
                usedMocha = value;
            }
        }
        public string Name { get; }
    }
}
