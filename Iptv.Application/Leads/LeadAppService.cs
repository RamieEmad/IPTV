using Iptv.Application.Contracts.Leads;
using Iptv.Domain.Leads;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Iptv.Application.Leads;

public class LeadAppService : ApplicationService, ILeadAppService
{
    private readonly IRepository<Lead, Guid> _leadRepository;

    public async Task<string> CreateAsync(CreateLeadDto input)
    {
        var lead = new Lead(
            GuidGenerator.Create(),
            input.Name,
            input.PhoneNumber,
            input.Message
        );

        await _leadRepository.InsertAsync(lead);

        return "تم استلام طلبك بنجاح، وسنتواصل معك قريبًا.";
    }
}