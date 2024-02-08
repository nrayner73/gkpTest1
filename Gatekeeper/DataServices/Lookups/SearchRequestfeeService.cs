using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchRequestfeeService : ISearchRequestfeeService
    {
        private LookupDbContext _context;
        public SearchRequestfeeService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchRequestfee> GetRequestfeeList(int fileid)
        {
            SqlParameter parms = new SqlParameter { ParameterName = "@fileid", Value = fileid == 0 ? DBNull.Value : fileid };
            List<SearchRequestfee> items = new List<SearchRequestfee>();
            items = _context?.RequestfeeInfos.FromSqlRaw("Execute [gkp].[GetRequestfee] @fileid", parms).ToList();

            return items;
        }

        
    }
}
