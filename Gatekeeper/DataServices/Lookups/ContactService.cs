using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class ContactService : IContactService
    {
        private LookupDbContext _context;
        public ContactService(LookupDbContext context) { _context = context; }

        public List<ContactInfo> GetContactInfo()
        {
            List<ContactInfo> contactInfos = new List<ContactInfo>();
            contactInfos = _context?.ContactInfos?.FromSqlRaw("EXECUTE [gkp].[GetContact] ").ToList();

            return contactInfos;
        }
    }
}
