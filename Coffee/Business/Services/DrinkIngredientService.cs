using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Coffee
{
    public class DrinkIngredientService:IDrinkIngredientService
    {

        private readonly IUnitOfWork unit;
        private readonly IMapper mapper;
        public DrinkIngredientService(IUnitOfWork unit, IMapper mapper)
        {
            this.unit = unit;
            this.mapper = mapper;
        }
        public IEnumerable<DrinkIngredientModel> GetDrinkIngredients()
        {
            return mapper.Map<IEnumerable<DrinkIngredientModel>>(unit.DrinkIngredientRepository.GetAll());
        }
    }
}
