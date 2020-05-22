using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Coffee
{
    public class DrinkService:IDrinkService
    {
        private readonly IUnitOfWork unit;
        private readonly IMapper mapper;
        public DrinkService(IUnitOfWork unit, IMapper mapper)
        {
            this.unit = unit;
            this.mapper = mapper;
        }
        public IEnumerable<DrinkModel> GetDrinks()
        {
            return mapper.Map<IEnumerable<DrinkModel>>(unit.DrinkRepository.GetAll());
        }
        public IEnumerable<DrinkModel> GetDrinkById(int drinkId) 
        {
            return mapper.Map<IEnumerable<DrinkModel>>(unit.DrinkRepository.GetAll().Where(d => d.Id==drinkId));
        }
    }
}
