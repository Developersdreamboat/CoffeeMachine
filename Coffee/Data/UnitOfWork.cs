using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Coffee
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly DbContext context;
        private IAutomatRepository automatRepository;
        private IDrinkRepository drinkRepository;
        private IIngredientRepository ingredientRepository;
        private IAutomatIngredientRepository automatIngredientRepository;
        private IAutomatOrderRepository automatOrderRepository;
        private IDrinkIngredientRepository drinkIngredientRepository;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public IAutomatRepository AutomatRepository
        {
            get
            {
                return automatRepository ?? new AutomatRepository(context);
            }
        }
        public IDrinkRepository DrinkRepository
        {
            get
            {
                return drinkRepository ?? new DrinkRepository(context);
            }
        }
        public IIngredientRepository IngredientRepository
        {
            get
            {
                return ingredientRepository ?? new IngredientRepository(context);
            }
        }
        public IAutomatIngredientRepository AutomatIngredientRepository
        {
            get
            {
                return automatIngredientRepository ?? new AutomatIngredientRepository(context);
            }
        }
        public IAutomatOrderRepository AutomatOrderRepository
        {
            get
            {
                return automatOrderRepository ?? new AutomatOrderRepository(context);
            }
        }
        public IDrinkIngredientRepository DrinkIngredientRepository
        {
            get
            {
                return drinkIngredientRepository ?? new DrinkIngredientRepository(context);
            }
        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
