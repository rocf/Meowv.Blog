﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace Meowv.Blog.Application.Caching
{
    [DependsOn(typeof(AbpCachingModule),
                typeof(MeowvBlogDomainSharedModule)

    )]
    public class MeowvBlogApplicationCachingModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
