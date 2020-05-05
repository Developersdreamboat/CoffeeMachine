using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coffee
{
    public class AutomatEntity
    {
        [ForeignKey("MaxIngredients")]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IngredientEntity MaxIngredients { get; set; }
        private IngredientEntity _curreentIngredients;
        private int usedCapuccino;
        private int usedLatte;
        private int usedMocha;

        public AutomatEntity(string name, IngredientEntity maxIngredients)
        {
            Name = name;
            MaxIngredients = maxIngredients;
            _curreentIngredients = maxIngredients;
        }
        public AutomatEntity() { }

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
    }
}
