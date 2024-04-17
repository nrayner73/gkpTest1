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
            //TO DO - create Stored procedure as part of migration?
            List<ProcessingDeficiencyView> items = new List<ProcessingDeficiencyView>();
            items = _context?.ProcessingDeficiencyInfos.FromSqlRaw("Execute [gkp].[GetProcessingDeficiency]").ToList();

            items = items.Where(c => c.Status != "del").OrderBy(x => x.SortBy).ToList();

            return items;
        }
    }
}
