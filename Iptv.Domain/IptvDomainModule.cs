using Iptv.Domain.Shared;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Iptv.Domain;

[DependsOn(
    typeof(IptvDomainSharedModule),
    typeof(AbpDddDomainModule)
)]
public class IptvDomainModule : AbpModule
{
}