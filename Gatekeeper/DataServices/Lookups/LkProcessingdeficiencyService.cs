using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces.Lookups;

namespace Gatekeeper.DataServices.Lookups
{
    public class LkProcessingdeficiencyService : ILkProcessingdeficiencyService
    {
        private AppDbContext _context;

        public LkProcessingdeficiencyService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkProcessingdeficiency>> GetLkProcessingdeficiencyList()
        {
            return await _context.LkProcessingdeficiencies
                    .ToListAsync();
        }

        public async Task<LkProcessingdeficiency> GetLkProcessingdeficiencyById(int id)
        {
            return await _context.LkProcessingdeficiencies
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkProcessingdeficiency> CreateLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency)
        {
            _context.LkProcessingdeficiencies.Add(lkprocessingdeficiency);
            await _context.SaveChangesAsync();
            return lkprocessingdeficiency;
        }
        public async Task UpdateLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency)
        {
            _context.LkProcessingdeficiencies.Update(lkprocessingdeficiency);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency)
        {
            //TO DO - remove references to deleted item when deleted?
            lkprocessingdeficiency.Status = "del";
            _context.LkProcessingdeficiencies.Update(lkprocessingdeficiency);
            await _context.SaveChangesAsync();
        }

    }
}
