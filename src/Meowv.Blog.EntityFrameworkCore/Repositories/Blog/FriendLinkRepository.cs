using Meowv.Blog.Blog;
using Meowv.Blog.Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Meowv.Blog.Repositories.Blog
{
    /// <summary>
    /// PostTagRepository
    /// </summary>
    public class FriendLinkRepository : EfCoreRepository<MeowvBlogDbContext, FriendLink, int>, IFriendLinkRepository
    {
        public FriendLinkRepository(IDbContextProvider<MeowvBlogDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
