using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Meowv.Blog.Blog.Repositories
{
    /// <summary>
    /// IPostRepository
    /// </summary>
    public interface IPostRepository : IRepository<Post, int>
    {
    }
}
