using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.DataServices
{
    public class LkCityService : ILkCityService
    {
        private AppDbContext _context;

        public LkCityService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkCity>> GetLkCityList()
        {
            return await _context.LkCities.ToListAsync();
        }

        public async Task<LkCity> GetLkCityById(int id)
        {
            return await _context.LkCities.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkCity> CreateLkCity(LkCity lkcity)
        {
            _context.LkCities.Add(lkcity);
            await _context.SaveChangesAsync();
            return lkcity;
        }
        public async Task UpdateLkCity(LkCity lkcity)
        {
            _context.LkCities.Update(lkcity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkCity(LkCity lkcity)
        {
            _context.LkCities.Remove(lkcity);
            await _context.SaveChangesAsync();
        }

    }
}
