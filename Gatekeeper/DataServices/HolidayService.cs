using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Microsoft.Data.SqlClient;
using Gatekeeper.Interfaces;

namespace Gatekeeper.DataServices
{
    public class HolidayService : IHolidayService
    {
        private AppDbContext _context;

        public HolidayService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Holiday>> GetHolidayList(int year)
        {
            List<Holiday> items = new List<Holiday>();
            if (year > 0 )
            {
                items = await _context.Holidays
                        .ToListAsync();
            }
            else
            {
                items = await _context.Holidays.Where(x => ((DateTime)x.Holidaydate).Year == year)
                       .ToListAsync();

            }

            return items;
        }

        public async Task<Holiday> GetHolidayById(int id)
        {
            return await _context.Holidays
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Holiday>> CopyLastYearHoliday(string regno)
        {

            SqlParameter parms = new SqlParameter { ParameterName = "@regno", Value = regno == "" ? DBNull.Value : regno };
            List<Holiday> items = new List<Holiday>();
            //GetDisclosureitems

            items = _context?.Holidays.FromSqlRaw("Execute [gkp].[CreateHolidayFromLastYear] @regno", parms).ToList();

            return items;

        }
        public async Task<Holiday> CreateHoliday(Holiday holiday)
        {
            _context.Holidays.Add(holiday);
            await _context.SaveChangesAsync();
            return holiday;
        }
        public async Task UpdateHoliday(Holiday holiday)
        {
            _context.Holidays.Update(holiday);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHoliday(Holiday holiday)
        {
            _context.Holidays.Remove(holiday);
            await _context.SaveChangesAsync();
        }

    }
}
