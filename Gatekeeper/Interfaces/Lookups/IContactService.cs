using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface IContactService
    {
        List<ContactInfo> GetContactInfo();
    }
}
