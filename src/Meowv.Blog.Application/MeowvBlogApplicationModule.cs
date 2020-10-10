﻿using Meowv.Blog.Application.Caching;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Meowv.Blog
{
    [DependsOn(
        typeof(AbpIdentityApplicationModule),
        typeof(MeowvBlogApplicationCachingModule),
        typeof(AbpAutoMapperModule)
        )]
    public class MeowvBlogApplicationModule: AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<MeowvBlogApplicationModule>(validate: true);
                options.AddProfile<MeowvBlogAutoMapperProfile>(validate: true);
            });
        }
    }
}
