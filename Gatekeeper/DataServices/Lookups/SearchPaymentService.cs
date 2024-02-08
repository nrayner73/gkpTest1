using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchPaymentService : ISearchPaymentService
    {

        private LookupDbContext _context;
        public SearchPaymentService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchPayment> GetPaymentList(int fileid)
        {
            SqlParameter parms = new SqlParameter { ParameterName = "@fileid", Value = fileid == 0 ? DBNull.Value : fileid };
            List<SearchPayment> notes = new List<SearchPayment>();
            notes = _context?.PaymentInfos.FromSqlRaw("Execute [gkp].[GetPayment] @fileid", parms).ToList();

            return notes;
        }
    }
}
