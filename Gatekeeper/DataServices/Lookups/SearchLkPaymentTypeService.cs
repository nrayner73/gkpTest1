using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchLkPaymentTypeService : ISearchLkPaymentTypeService
    {
        private LookupDbContext _context;

        public SearchLkPaymentTypeService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchLkPaymentTypes> GetLkPaymentTypeList()
        {
            List<SearchLkPaymentTypes> items = new List<SearchLkPaymentTypes>();
            items = _context?.LkPaymentTypeInfos.FromSqlRaw("Execute [gkp].[GetPaymentTypes] @status = '1'").ToList();
            return items;
        }
    }
}
