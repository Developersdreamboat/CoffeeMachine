using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public interface IIngredientService
    {
        IEnumerable<IngredientModel> GetIngredients();
        IEnumerable<IngredientModel> GetIngredientsByName(string name);
    }
}
