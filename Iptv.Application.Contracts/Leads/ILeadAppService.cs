using Volo.Abp.Application.Services;

namespace Iptv.Application.Contracts.Leads;

public interface ILeadAppService : IApplicationService
{
    Task<string> CreateAsync(CreateLeadDto input);
}