using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class LkExtensionsService : ILkExtensionsService
    {
        private AppDbContext _context;

        public LkExtensionsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkExtension>> GetLkExtensionsList()
        {
            return await _context.LkExtensions
                    .ToListAsync();
        }
    
        public async Task<LkExtension> GetLkExtensionsById(int id)
        {
            return await _context.LkExtensions
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkExtension> CreateLkExtensions(LkExtension lkextensions)
        {
            _context.LkExtensions.Add(lkextensions);
            await _context.SaveChangesAsync();
            return lkextensions;
        }
        public async System.Threading.Tasks.Task UpdateLkExtensions(LkExtension lkextensions)
        {
            _context.LkExtensions.Update(lkextensions);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteLkExtensions(LkExtension lkextensions)
        {
            _context.LkExtensions.Remove(lkextensions);
            await _context.SaveChangesAsync();
        }

    }
}
