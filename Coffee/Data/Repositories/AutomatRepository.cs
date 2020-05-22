﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
namespace Coffee
{
    public class AutomatRepository:Repository<AutomatEntity>, IAutomatRepository
    {
        public AutomatRepository(DbContext context) : base(context)
        {
        }
    }
}
