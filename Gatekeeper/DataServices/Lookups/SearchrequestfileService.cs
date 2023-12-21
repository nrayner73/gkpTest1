using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchrequestfileService : ISearchrequestfileService
    {
        private LookupDbContext _context;
        public SearchrequestfileService(LookupDbContext context) { _context = context; }

         List<Searchrequestfile> ISearchrequestfileService.GetRequestfileList()
        {
            List<Searchrequestfile> requestfileinfo = new List<Searchrequestfile>();
            requestfileinfo = _context?.RequestfileInfos?.FromSqlRaw("EXECUTE [gkp].[SearchRequestFiles] ").ToList();

            return requestfileinfo;
        }
    }
}
