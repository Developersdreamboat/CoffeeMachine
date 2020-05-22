using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Coffee
{
    public class AutomatService:IAutomatService
    {
        private readonly IUnitOfWork unit;
        private readonly IMapper mapper;
        private readonly IOrderService orderService;
        private readonly IDrinkService drinkService;
        private readonly IDrinkIngredientService drinkIngredientService;
        private readonly IAutomatIngredientService automatIngredientService;
        public AutomatService(IUnitOfWork unit, IMapper mapper, IOrderService orderService, IDrinkService drinkService
            , IDrinkIngredientService drinkIngredientService, IAutomatIngredientService automatIngredientService)
        {
            this.unit= unit;
            this.mapper = mapper;
            this.orderService = orderService;
            this.drinkService = drinkService;
            this.drinkIngredientService = drinkIngredientService;
            this.automatIngredientService = automatIngredientService;
        }
        public IEnumerable<AutomatModel> GetAutomats()
        {
            return mapper.Map<IEnumerable<AutomatModel>>(unit.AutomatRepository.GetAll());
        }
        public int GetIngredientsUsing(int ingredientId,int automatId, DateTime first, DateTime second)
        {

            int usedChoosenIngredient = 0;
            IEnumerable<DrinkIngredientModel> composition;
            IEnumerable<AutomatOrderModel> orders = orderService.GetOrders().
                Where(o => o.AutomatId == automatId && o.OrderTime > first && o.OrderTime < second);
            foreach (AutomatOrderModel o in orders) 
            {
                composition = drinkIngredientService.GetDrinkIngredients().Where(c => c.DrinkId == o.DrinkId && c.IngredientId==ingredientId);
                foreach (DrinkIngredientModel c in composition) 
                {
                    usedChoosenIngredient = usedChoosenIngredient + c.CountForCurrent;
                }
            }
            return usedChoosenIngredient;
        }

        public int CountRefillPeriod(int ingredientId, int automatId, DateTime first, DateTime second)
        {
            AutomatIngredientModel automatsIngredients = automatIngredientService.GetAutomatIngredients().
                Where(a => a.AutomatId == automatId).First();
            var automatMaxIngredients = automatsIngredients.MaxIngredients;
            var usedChoosenIngredient = GetIngredientsUsing(ingredientId,automatId, first, second);
            var daysChoosen = (second - first).TotalDays;
            var refillSpeed = usedChoosenIngredient / daysChoosen;
            var refillPeriod = automatMaxIngredients/refillSpeed;
            return (int)refillPeriod;
        }
    }
}
