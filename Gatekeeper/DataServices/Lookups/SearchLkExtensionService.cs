using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchLkExtensionService : ISearchLkExtensionService
    {
        private LookupDbContext _context;

        public SearchLkExtensionService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchLkExtension> GetLkExtensionList()
        {
            List<SearchLkExtension> items = new List<SearchLkExtension>();
            items = _context?.LkExtensionInfos.FromSqlRaw("exec [gkp].[GetLkExtensions]").ToList();

            items = items.Where(c => c.Status != "del").ToList();

            return items;
        }
    }
}
