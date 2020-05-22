using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Coffee
{
    public class AutomatOrderRepository:Repository<AutomatOrderEntity>,IAutomatOrderRepository
    {
        public AutomatOrderRepository(DbContext context) : base(context)
        {
        }
    }
}
