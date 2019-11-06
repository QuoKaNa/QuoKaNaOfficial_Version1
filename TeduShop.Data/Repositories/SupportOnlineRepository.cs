using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Data.Repositories
{
    public interface ISupportOnlineRepository:IRepository<SupportOnline>
    {

    }
    public class SupportOnlineRepository:RepositoryBase<SupportOnline>,ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
