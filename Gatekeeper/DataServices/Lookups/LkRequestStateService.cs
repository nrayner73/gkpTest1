using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces.Lookups;
using static System.Collections.Specialized.BitVector32;

namespace Gatekeeper.DataServices.Lookups
{
    public class LkRequestStateService : ILkRequestStateService
    {
        private AppDbContext _context;

        public LkRequestStateService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkRequeststate>> GetLkRequestStateList()
        {
            return await _context.LkRequeststates
                    .ToListAsync();
        }

        public async Task<LkRequeststate> GetLkRequestStateById(int id)
        {
            return await _context.LkRequeststates
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkRequeststate> CreateLkRequestState(LkRequeststate lkrequeststate)
        {
            lkrequeststate.Status = "1";

            var lastRecord = await _context?.LkRequeststates.OrderByDescending(x => x.Sortby)
                .FirstOrDefaultAsync();

            if (lastRecord is not null)
            {
                lkrequeststate.Sortby = lastRecord.Sortby + 1;
            }
            else
            {
                lkrequeststate.Sortby = 1; //1st Request State record
            }

            _context.LkRequeststates.Add(lkrequeststate);
            await _context.SaveChangesAsync();
            return lkrequeststate;
        }
        public async Task UpdateLkRequestState(LkRequeststate lkrequeststate)
        {
            _context.LkRequeststates.Update(lkrequeststate);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkRequestState(LkRequeststate lkrequeststate)
        {
            lkrequeststate.Status = "0";
            _context.LkRequeststates.Update(lkrequeststate);
            await _context.SaveChangesAsync();
        }
    }
}
