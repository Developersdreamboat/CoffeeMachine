using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly CoffeeContext context;
        private IRepository<AutomatEntity> automatRepository;

        public UnitOfWork(CoffeeContext context)
        {
            this.context = context;
        }

        public IRepository<AutomatEntity> AutomatRepository
        {
            get
            {
                return automatRepository ?? new AutomatRepository(context);
            }
        }


        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
