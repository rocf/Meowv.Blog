using Hangfire;
using Hangfire.Dashboard.BasicAuthorization;
using Hangfire.SqlServer;
using Meowv.Blog.Configurations;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.BackgroundJobs.Hangfire;
using Volo.Abp.Modularity;

namespace Meowv.Blog.BackgroundJobs
{
    [DependsOn(
        typeof(AbpBackgroundJobsHangfireModule),
        typeof(MeowvBlogApplicationContractsModule)
        )]
    public class MeowvBlogBackgroundJobsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHangfire(config =>
            {
                config.UseStorage(
                    new SqlServerStorage(AppSettings.ConnectionStrings,
                    new SqlServerStorageOptions
                    {
                        //TablePrefix = MeowvBlogConsts.DbTablePrefix + "hangfire"
                    }));
            });
        }


        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();

            app.UseHangfireServer();
            app.UseHangfireDashboard(
                options: new DashboardOptions
                {
                    Authorization = new[]
                    {
                        new BasicAuthAuthorizationFilter(new BasicAuthAuthorizationFilterOptions
                        {
                            RequireSsl = false,
                            SslRedirect = false,
                            LoginCaseSensitive = true,
                            Users = new[]
                            {
                                new BasicAuthAuthorizationUser
                                {
                                    Login = AppSettings.Hangfire.Login,
                                    PasswordClear = AppSettings.Hangfire.Password
                                }
                            }
                        })
                    },
                    DashboardTitle = "任务调度中心"
                });

            var service = context.ServiceProvider;

            service.UseHangfireTest();
            service.UseWallpaperJob();
        }
    }
}

