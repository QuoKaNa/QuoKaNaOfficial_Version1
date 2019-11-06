using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
namespace Data.Repositories
{
    public interface IOrderRepository:IRepository<Order>
    {

    }
    public class OrderRepository:RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
    
}
