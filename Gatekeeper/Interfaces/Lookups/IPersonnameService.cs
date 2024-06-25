using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface IPersonnameService
    {
        List<PersonName> GetNames();
        List<POIName> GetPOINames();
        List<CompanyName> GetCompanyNames();
        List<PersonPhone> GetPersonPhones();
        List<PersonEmail> GetPersonEmails();

    }
}
