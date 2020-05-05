using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        void Create(TEntity entity);

        void Delete(TEntity entity);

        void Edit(TEntity entity);

    }
}
