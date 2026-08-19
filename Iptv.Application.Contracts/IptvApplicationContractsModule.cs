using Iptv.Domain.Shared;
using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace Iptv.Application.Contracts;

[DependsOn(
    typeof(IptvDomainSharedModule),
    typeof(AbpDddApplicationContractsModule)
)]
public class IptvApplicationContractsModule : AbpModule
{
}