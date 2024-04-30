using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchLkSectionService : ISearchLkSectionService
    {
        private LookupDbContext _context;

        public SearchLkSectionService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchLkSections> GetLkSectionList()
        {
            List<SearchLkSections> items = new List<SearchLkSections>();
            items = _context?.LkSectionInfos.FromSqlRaw("exec [gkp].[GetSections]").ToList();

            items = items.Where(c => c.Status != "del").ToList();

            return items;
        }
    }
}
