using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
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
            _context.LkRequeststates.Add(lkrequeststate);
            await _context.SaveChangesAsync();
            return lkrequeststate;
        }
        public async System.Threading.Tasks.Task UpdateLkRequestState(LkRequeststate lkrequeststate)
        {
            _context.LkRequeststates.Update(lkrequeststate);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteLkRequestState(LkRequeststate lkrequeststate)
        {
            _context.LkRequeststates.Remove(lkrequeststate);
            await _context.SaveChangesAsync();
        }
    }
}
