using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class ViewProcessingDeficiencyService : IViewProcessingDeficiencyService
    {
        private LookupDbContext _context;

        public ViewProcessingDeficiencyService(LookupDbContext context)
        {
            _context = context;
        }


        public List<ProcessingDeficiencyView> GetProcessingDeficiencyList()
        {
            //SqlParameter parms = new SqlParameter { ParameterName = "@year", Value = string.IsNullOrEmpty(year)  ? DBNull.Value : year };
            List<ProcessingDeficiencyView> items = new List<ProcessingDeficiencyView>();
            items = _context?.ProcessingDeficiencyInfos.FromSqlRaw("Execute [gkp].[GetProcessingDeficiency]").ToList();

            return items;
        }
    }
}
