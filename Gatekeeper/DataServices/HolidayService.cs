using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class HolidayService : IHolidayService
    {
        private AppDbContext _context;

        public HolidayService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Holiday>> GetHolidayList()
        {
            return await _context.Holidays
                    .ToListAsync();
        }
    
        public async Task<Holiday> GetHolidayById(int id)
        {
            return await _context.Holidays
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Holiday> CreateHoliday(Holiday holiday)
        {
            _context.Holidays.Add(holiday);
            await _context.SaveChangesAsync();
            return holiday;
        }
        public async System.Threading.Tasks.Task UpdateHoliday(Holiday holiday)
        {
            _context.Holidays.Update(holiday);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteHoliday(Holiday holiday)
        {
            _context.Holidays.Remove(holiday);
            await _context.SaveChangesAsync();
        }

    }
}
