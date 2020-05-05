using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public interface IAutomatService
    {
        IngredientModel GetIngredientsUsing(AutomatModel automat);
        int CountRefillPeriod(AutomatModel automat);
        IEnumerable<AutomatModel> GetAutomats();
    }
}
