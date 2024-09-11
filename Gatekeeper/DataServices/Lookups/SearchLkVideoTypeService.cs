using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchLkVideoTypeService : ISearchLkVideoTypeService
    {
        private LookupDbContext _context;

        public SearchLkVideoTypeService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchLkVideoType> GetLkVideoTypeList()
        {
            List<SearchLkVideoType> items = new List<SearchLkVideoType>();
            items = _context?.LkVideoTypeInfos.FromSqlRaw("exec [gkp].[GetVideoTypes]").ToList();

            items = items.Where(c => c.Status != "del").ToList();

            return items;
        }
    }
}
