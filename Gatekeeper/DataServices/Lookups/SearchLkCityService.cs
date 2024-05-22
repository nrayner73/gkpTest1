using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchLkCityService : ISearchLkCityService
    {
        private LookupDbContext _context;

        public SearchLkCityService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchLkCity> GetLkCityList()
        {
            List<SearchLkCity> items = new List<SearchLkCity>();
            items = _context?.LkCityInfos.FromSqlRaw("Execute [gkp].[GetCities]").ToList();

            items = items.Where(c => c.Status != "del").ToList();

            return items;
        }
    }
}
