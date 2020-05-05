using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    public interface IUnitOfWork
    {
        IAutomatRepository AutomatRepository { get; }
        void SaveChanges();
    }
}
