using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
namespace Coffee
{
    public class AutomatRepository:IAutomatRepository
    {
        private CoffeeContext context;

        public AutomatRepository(CoffeeContext context)
        {
            this.context = context;
        }

        public void Create(AutomatEntity entity)
        {
            context.Automats.Add(entity);
        }

        public void Delete(AutomatEntity entity)
        {
            context.Automats.Remove(entity);
        }

        public void Edit(AutomatEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }


        public IEnumerable<AutomatEntity> GetAll()
        {
            return context.Automats.ToList();
        }
    }
}
