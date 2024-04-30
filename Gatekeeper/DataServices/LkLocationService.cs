using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using Gatekeeper.Interfaces.Lookups;
using static System.Collections.Specialized.BitVector32;

namespace Gatekeeper.Services
{
    public class LkLocationService : ILkLocationService
    {
        private AppDbContext _context;

        public LkLocationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkLocationsearch>> GetLkLocationList()
        {
            return await _context.LkLocationsearchs
                    .ToListAsync();
        }
        public async Task<LkLocationsearch> GetLkLocationById(int id)
        {
            return await _context.LkLocationsearchs.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkLocationsearch> CreateLkLocation(LkLocationsearch lklocation)
        {
            var lastRecord = await _context?.LkLocationsearchs.OrderByDescending(x => x.Sortby)
                .FirstOrDefaultAsync();

            if (lastRecord is not null)
            {
                lklocation.Sortby = lastRecord.Sortby + 1;
            }
            else
            {
                lklocation.Sortby = 1; //1st Location record
            }
            _context.LkLocationsearchs.Add(lklocation);
            await _context.SaveChangesAsync();
            return lklocation;
        }
        public async System.Threading.Tasks.Task UpdateLkLocation(LkLocationsearch lklocation)
        {
            _context.LkLocationsearchs.Update(lklocation);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteLkLocation(LkLocationsearch lklocation)
        {
            lklocation.Status = "del";

            _context.LkLocationsearchs.Update(lklocation);
            await _context.SaveChangesAsync();
        }

    }
}
