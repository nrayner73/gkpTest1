using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchLkLocationService : ISearchLkLocationService
    {
        private LookupDbContext _context;

        public SearchLkLocationService(LookupDbContext context)
        {
            _context = context;
        }
        public List<SearchLkLocation> GetLkLocationList()
        {
            List<SearchLkLocation> items = new List<SearchLkLocation>();
            items = _context?.LkLocationInfos.FromSqlRaw("Execute [gkp].[GetLocations] @status = '1'").ToList();

            return items;
        }
    }
}
