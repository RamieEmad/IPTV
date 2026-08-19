namespace Iptv.Application.Contracts.Leads;

public class CreateLeadDto
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string? Message { get; set; }
}