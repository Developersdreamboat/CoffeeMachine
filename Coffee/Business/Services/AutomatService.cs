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
        public AutomatService(IUnitOfWork unit, IMapper mapper)
        {
            this.unit= unit;
            this.mapper = mapper;
        }
        public IEnumerable<AutomatModel> GetAutomats()
        {
            return mapper.Map<IEnumerable<AutomatModel>>(unit.AutomatRepository.GetAll());
        }
        public IngredientModel GetIngredientsUsing(AutomatModel automat)
        {
            DrinkModel Capuccino = new DrinkModel(1, new IngredientModel(1, 2, 3));
            DrinkModel Latte = new DrinkModel(2, new IngredientModel(3, 3, 3));
            DrinkModel Mocha = new DrinkModel(3, new IngredientModel(3,4,5));
            var usedIngs = new IngredientModel();
            
            usedIngs = Capuccino.Composition.Multiply(automat.UsedCapuccino)
                     + Latte.Composition.Multiply(automat.UsedLatte)
                     + Mocha.Composition.Multiply(automat.UsedMocha);
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
