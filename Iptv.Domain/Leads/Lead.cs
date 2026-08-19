using Iptv.Domain.Shared.Enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace Iptv.Domain.Leads;

public class Lead : AuditedAggregateRoot<Guid>
{
    public string Name { get; private set; }
    public string PhoneNumber { get; private set; }
    public string? Message { get; private set; }
    public LeadStatus Status { get; private set; }

    protected Lead()
    {
    }

    public Lead(
        Guid id,
        string name,
        string phoneNumber,
        string? message = null)
        : base(id)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Message = message;
        Status = LeadStatus.New;
    }
}