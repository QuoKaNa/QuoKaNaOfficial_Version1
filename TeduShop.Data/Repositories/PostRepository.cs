﻿using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Data.Repositories
{
    public interface IPostRepository:IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }
    public class PostRepository:RepositoryBase<Post>,IPostRepository
    {
        public PostRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;

            totalRow = query.Count();

            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);

            return query;
        }
    }
}
