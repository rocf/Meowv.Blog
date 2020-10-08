using Meowv.Blog.Configurations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;

namespace Meowv.Blog
{
    [DependsOn(
        typeof(MeowvBlogDomainModule),
        typeof(AbpEntityFrameworkCoreModule),
        typeof(AbpEntityFrameworkCoreSqlServerModule)
        )]
    public class MeowvBlogFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MeowvBlogDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options =>
            {
                switch (AppSettings.EnableDb)
                {
                    
                    case "SqlServer":
                        options.UseSqlServer();
                        break;
                    default:
                        options.UseSqlServer();
                        break;
                }
            });
        }
    }
}
