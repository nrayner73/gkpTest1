using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class ViewLkPaymentTypeService : IViewLkPaymentTypeService
    {
        private LookupDbContext _context;

        public ViewLkPaymentTypeService(LookupDbContext context)
        {
            _context = context;
        }

        public List<LkPaymentTypeView> GetLkPaymenttypeList()
        {
            List<LkPaymentTypeView> items = new List<LkPaymentTypeView>();
            items = _context?.LkPaymentTypeInfos.FromSqlRaw("Execute [gkp].[GetPaymentTypes]").ToList();
            return items;
        }
    }
}
