using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class AutomatRepository:IAutomatRepository
    {
        private CoffeeContext context;

        public AutomatRepository(CoffeeContext context)
        {
            this.context = context;
        }

        public IEnumerable<AutomatEntity> GetAll()
        {
            return context.Automats.ToList();
        }
    }
}
