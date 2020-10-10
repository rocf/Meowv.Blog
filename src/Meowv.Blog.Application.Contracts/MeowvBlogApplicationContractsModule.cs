using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace Meowv.Blog
{
    [DependsOn(typeof(MeowvBlogDomainModule))]
    public class MeowvBlogApplicationContractsModule : AbpModule
    {

    }
}
