using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace Coffee
{
    public class AutomatIngredientService:IAutomatIngredientService
    {
        private readonly IUnitOfWork unit;
        private readonly IMapper mapper;
        public AutomatIngredientService(IUnitOfWork unit, IMapper mapper)
        {
            this.unit = unit;
            this.mapper = mapper;
        }
        public IEnumerable<AutomatIngredientModel> GetAutomatIngredients()
        {
            return mapper.Map<IEnumerable<AutomatIngredientModel>>(unit.AutomatIngredientRepository.GetAll());
        }
    }
}
