using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Coffee 
{ 
    public class IngredientService:IIngredientService
    {
        private readonly IUnitOfWork unit;
        private readonly IMapper mapper;
        public IngredientService(IUnitOfWork unit, IMapper mapper)
        {
            this.unit = unit;
            this.mapper = mapper;
        }
        public IEnumerable<IngredientModel> GetIngredients()
        {
            return mapper.Map<IEnumerable<IngredientModel>>(unit.IngredientRepository.GetAll());
        }
        public IEnumerable<IngredientModel> GetIngredientsByName(string name) 
        {
            return mapper.Map<IEnumerable<IngredientModel>>(unit.IngredientRepository.GetAll()).Where(i=>i.Name==name);
        }
    }
}
