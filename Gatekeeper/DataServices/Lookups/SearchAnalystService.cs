using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchAnalystService : ISearchAnalystService
    {
        private LookupDbContext _context;

        public SearchAnalystService(LookupDbContext context)
        {
            _context = context;
        }
        
        public List<SearchAnalyst> GetAnalystsList()
        {
            List<SearchAnalyst> items = new List<SearchAnalyst>();
            items = _context?.AnalystInfos.FromSqlRaw("exec [gkp].[GetAnalysts]").ToList();

            items = items.Where(c => c.Status != "del").ToList();

            return items;
        }
    }
}
