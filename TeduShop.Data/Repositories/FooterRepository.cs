﻿using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Data.Repositories
{
    public interface IFooterRepository:IRepository<Footer>
    {

    }
    public class FooterRepository: RepositoryBase<Footer>,IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
