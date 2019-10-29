using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Data.Repositories
{
    public interface IVisitorStaticRepository:IRepository<VisitorStatistic>
    {

    }
    public class VisitorStaticRepository:RepositoryBase<VisitorStatistic>,IVisitorStaticRepository
    {
        public VisitorStaticRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
