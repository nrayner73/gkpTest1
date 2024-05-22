using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchLkRecordDeliveryMethodService : ISearchLkRecordDeliveryMethodService
    {
        private LookupDbContext _context;

        public SearchLkRecordDeliveryMethodService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchLkRecordDeliveryMethod> GetLkRecordDeliveryMethodList()
        {
            List<SearchLkRecordDeliveryMethod> items = new List<SearchLkRecordDeliveryMethod>();
            items = _context?.LkRecordDeliveryMethodInfos.FromSqlRaw("exec [gkp].[GetRecordDeliveryMethods]").ToList();

            items = items.Where(c => c.Status != "del").ToList();

            return items;
        }
    }
}
