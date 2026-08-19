using Iptv.Application.Contracts;
using Iptv.Domain;
using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace Iptv.Application;

[DependsOn(
    typeof(IptvApplicationContractsModule),
    typeof(IptvDomainModule),
    typeof(AbpDddApplicationModule)
)]
public class IptvApplicationModule : AbpModule
{
}