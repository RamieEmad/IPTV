using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Iptv.Domain.Shared;

[DependsOn(
    typeof(AbpDddDomainSharedModule)
)]
public class IptvDomainSharedModule : AbpModule
{
}