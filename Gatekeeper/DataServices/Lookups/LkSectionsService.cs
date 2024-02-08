using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class LkSectionsService : ILkSectionsService
    {
        private AppDbContext _context;

        public LkSectionsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkSection>> GetLkSectionsList()
        {
            return await _context.LkSections
                    .ToListAsync();
        }
    
        public async Task<LkSection> GetLkSectionsById(int id)
        {
            return await _context.LkSections
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkSection> CreateLkSections(LkSection lksections)
        {
            _context.LkSections.Add(lksections);
            await _context.SaveChangesAsync();
            return lksections;
        }
        public async System.Threading.Tasks.Task UpdateLkSections(LkSection lksections)
        {
            _context.LkSections.Update(lksections);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteLkSections(LkSection lksections)
        {
            _context.LkSections.Remove(lksections);
            await _context.SaveChangesAsync();
        }

    }
}
