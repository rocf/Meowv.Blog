using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Meowv.Blog
{
    [DependsOn(typeof(AbpIdentityDomainModule))]
    public class MeowvBlogDomainModule : AbpModule
    {

    }
}
