using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Data.Repositories
{
    public interface ISlideRepository:IRepository<Slide>
    {

    }
    public class SlideRepository:RepositoryBase<Slide>,ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
