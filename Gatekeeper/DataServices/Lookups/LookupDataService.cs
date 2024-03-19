using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class LookupDataService : ILookupService
    {
        private LookupDbContext _context;

        public LookupDataService(LookupDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkSection>> GetLkSectionsList()
        {
            return await _context.LkSections
                    .ToListAsync();
        }
    }
}
