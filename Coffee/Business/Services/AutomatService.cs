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
        public AutomatService(IUnitOfWork unit, IMapper mapper, IOrderService orderService)
        {
            this.unit= unit;
            this.mapper = mapper;
            this.orderService = orderService;
        }
        public IEnumerable<AutomatModel> GetAutomats()
        {
            return mapper.Map<IEnumerable<AutomatModel>>(unit.AutomatRepository.GetAll());
        }
        public IngredientModel GetIngredientsUsing(int automatId)
        {

            usedIngs = ;
            return usedIngs;
        }

        public int CountRefillPeriod(AutomatModel automat)
        {
            var usedIngs = GetIngredientsUsing(automat) as IngredientModel;
            var usingSpeeds = new List<double>();
            usingSpeeds.Add(usedIngs.Coffee);
            usingSpeeds.Add(usedIngs.Milk);
            usingSpeeds.Add(usedIngs.Water);
            var refillPeriods = new List<double>();
            refillPeriods.Add((automat.MaxIngredients as IngredientModel).Coffee / usingSpeeds[0]);
            refillPeriods.Add((automat.MaxIngredients as IngredientModel).Milk / usingSpeeds[1]);
            refillPeriods.Add((automat.MaxIngredients as IngredientModel).Water / usingSpeeds[2]);
            var refillPeriod = refillPeriods.Min();
            return (int)refillPeriod;
        }
    }
}
