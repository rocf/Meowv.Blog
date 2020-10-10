using AutoMapper;
using Meowv.Blog.Blog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Meowv.Blog
{
    public class MeowvBlogAutoMapperProfile: Profile
    {
        public MeowvBlogAutoMapperProfile()
        {
            CreateMap<Post, PostDto>();

            CreateMap<PostDto, Post>()
                .ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
