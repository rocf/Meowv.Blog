using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Meowv.Blog.Blog.Repositories
{
    /// <summary>
    /// IFriendLinkRepository
    /// </summary>
    public interface IFriendLinkRepository : IRepository<FriendLink, int>
    {
    }
}
