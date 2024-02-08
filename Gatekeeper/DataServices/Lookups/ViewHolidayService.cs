using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class ViewHolidayService : IViewHolidayService
    {
        private LookupDbContext _context;

        public ViewHolidayService(LookupDbContext context)
        {
            _context = context;
        }


        public List<HolidayView> GetHolidayList(string  year)
        {
            SqlParameter parms = new SqlParameter { ParameterName = "@year", Value = string.IsNullOrEmpty(year)  ? DBNull.Value : year };
            List<HolidayView> items = new List<HolidayView>();
            items = _context?.HolidayInfos.FromSqlRaw("Execute [gkp].[GetholidayByYear] @year", parms).ToList();

            return items;
        }
    }
}
