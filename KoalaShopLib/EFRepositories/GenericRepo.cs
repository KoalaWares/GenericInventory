﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoalaShopLib.Models;

namespace KoalaShopLib.EFRepositories
{
    internal class GenericRepo<TEntity> : AbstractRepository<TEntity> where TEntity : class
    {
        public GenericRepo(DataAppContext dbContext)
            :base(dbContext)
        {

        }
    }
}
