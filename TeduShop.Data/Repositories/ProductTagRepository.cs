using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Data.Repositories
{
    public interface IProductTagRepository:IRepository<ProductTag>
    {

    }
    public class ProductTagRepository:RepositoryBase<ProductTag>,IProductTagRepository
    {
        public ProductTagRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
