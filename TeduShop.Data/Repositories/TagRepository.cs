using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Data.Repositories
{
    public interface ITagRepository : IRepository<TagRepository>
    {

    }
    public class TagRepository:RepositoryBase<TagRepository>,ITagRepository
    {
        public TagRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
