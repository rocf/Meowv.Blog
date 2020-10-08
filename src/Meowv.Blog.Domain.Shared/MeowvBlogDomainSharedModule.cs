using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Meowv.Blog
{
    [DependsOn(
        typeof(AbpIdentityDomainSharedModule)
        )]
    public class MeowvBlogDomainSharedModule : AbpModule
    {
        
    }
}
