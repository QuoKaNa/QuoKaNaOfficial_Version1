﻿using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Data.Repositories
{
    public interface ISystemConfigRepository:IRepository<SystemConfig>
    {

    }
    public class SystemConfigRepository:RepositoryBase<SystemConfig>,ISystemConfigRepository
    {
        public SystemConfigRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
