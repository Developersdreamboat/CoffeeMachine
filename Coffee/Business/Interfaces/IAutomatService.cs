using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public interface IAutomatService
    {
        int GetIngredientsUsing(int ingredientId, int automatId, DateTime first, DateTime second);
        int CountRefillPeriod(int automatId, int ingredientId, DateTime first, DateTime second);
        IEnumerable<AutomatModel> GetAutomats();
    }
}
