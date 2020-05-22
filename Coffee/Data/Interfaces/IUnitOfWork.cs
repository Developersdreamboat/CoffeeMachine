using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public interface IUnitOfWork
    {
        IAutomatRepository AutomatRepository { get; }
        IDrinkRepository DrinkRepository { get; } 
        IIngredientRepository IngredientRepository { get; }
        IAutomatIngredientRepository AutomatIngredientRepository { get; }
        IAutomatOrderRepository AutomatOrderRepository { get; }
        IDrinkIngredientRepository DrinkIngredientRepository { get; }
        void SaveChanges();
    }
}
