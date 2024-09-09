using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    //List<SearchLkRequestType> GetLkRequestTypeList();
    public class SearchLkRequestTypeService : ISearchLkRequestTypeService
    {
        private LookupDbContext _context;

        public SearchLkRequestTypeService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchLkRequestType> GetLkRequestTypeList()
        {
            List<SearchLkRequestType> items = new List<SearchLkRequestType>();
            items = _context?.LkRequestTypeInfos.FromSqlRaw("exec [gkp].[GetRequestTypes]").ToList();

            items = items.Where(c => c.Status != "del").ToList();

            return items;
        }
    }
}
