using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Data.Repositories
{
    public interface IPostTagRepository:IRepository<PostTag>
    {

    }
    public class PostTagRepository:RepositoryBase<PostTag>,IPostTagRepository
    {
        public PostTagRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
