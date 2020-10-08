using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Meowv.Blog.Blog.Repositories
{
    /// <summary>
    /// ICategoryRepository
    /// </summary>
    public interface ICategoryRepository : IRepository<Category, int>
    {
    }
}
