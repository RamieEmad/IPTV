using Iptv.Application;
using Volo.Abp.Modularity;

namespace Iptv.HttpApi;

[DependsOn(
    typeof(IptvApplicationModule)
)]
public class IptvHttpApiModule : AbpModule
{
}