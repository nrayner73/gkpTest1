using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces.Lookups;

namespace Gatekeeper.DataServices.Lookups
{
    public class LkExtensionService : ILkExtensionService
    {
        private AppDbContext _context;

        public LkExtensionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkExtension>> GetLkExtensionList()
        {
            return await _context.LkExtensions
                    .ToListAsync();
        }

        public async Task<LkExtension> GetLkExtensionById(int id)
        {
            return await _context.LkExtensions
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkExtension> CreateLkExtension(LkExtension lkextension)
        {
            var lastRecord = await _context?.LkExtensions.OrderByDescending(x => x.Sortby)
                .FirstOrDefaultAsync();

            if (lastRecord is not null)
            {
                lkextension.Sortby = lastRecord.Sortby + 1;
            }
            else
            {
                lkextension.Sortby = 1; //1st Extension record
            }

            _context.LkExtensions.Add(lkextension);
            await _context.SaveChangesAsync();
            return lkextension;
        }
        public async Task UpdateLkExtension(LkExtension lkextension)
        {
            _context.LkExtensions.Update(lkextension);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkExtension(LkExtension lkextension)
        {
            lkextension.Status = "del";
            _context.LkExtensions.Update(lkextension);
            await _context.SaveChangesAsync();
        }

    }
}
