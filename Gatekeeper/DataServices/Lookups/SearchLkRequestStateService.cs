using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchLkRequestStateService : ISearchLkRequestStateService
    {
        private LookupDbContext _context;

        public SearchLkRequestStateService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchLkRequestState> GetLkRequestStateList()
        {
            List<SearchLkRequestState> items = new List<SearchLkRequestState>();
            items = _context?.LkRequestStateInfos.FromSqlRaw("exec [gkp].[GetRequestStates] @status = '1'").ToList();
            return items;
        }
    }
}
