using Iptv.EntityFrameworkCore;
using Iptv.HttpApi;
using Volo.Abp.Modularity;

namespace Iptv.HttpApi.Host;

[DependsOn(
    typeof(IptvHttpApiModule),
    typeof(IptvEntityFrameworkCoreModule)
)]
public class IptvHttpApiHostModule : AbpModule
{
}