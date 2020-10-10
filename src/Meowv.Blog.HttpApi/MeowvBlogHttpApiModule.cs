using Meowv.Blog.Configurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Meowv.Blog
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(MeowvBlogApplicationModule)
        )]
    public class MeowvBlogHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }

    }
}
