using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class AddressService : IAddressService
    {
        private LookupDbContext _context;
        public AddressService(LookupDbContext context) { _context = context; }

        public List<AddressInfo> GetAddress()
        {
            List<AddressInfo> addresses = new List<AddressInfo>();
            addresses = _context?.AddressInfos?.FromSqlRaw("EXECUTE [gkp].[GetAddress] ").ToList();

            return addresses;
        }
    }
}
