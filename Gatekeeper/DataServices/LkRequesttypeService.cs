using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class LkRequesttypeService : ILkRequesttypeService
    {
        private readonly AppDbContext _context;

        public LkRequesttypeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkRequesttype>> GetLkRequesttypeList()
        {
            return await _context.LkRequesttypes 
                    .ToListAsync();
        }
    
        public async Task<LkRequesttype> GetLkRequesttypeById(int id)
        {
            return await _context.LkRequesttypes
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkRequesttype> CreateLkRequesttype(LkRequesttype lkrequesttype)
        {
            _context.LkRequesttypes.Add(lkrequesttype);
            await _context.SaveChangesAsync();
            return lkrequesttype;
        }
        public async System.Threading.Tasks.Task UpdateLkRequesttype(LkRequesttype lkrequesttype)
        {
            _context.LkRequesttypes.Update(lkrequesttype);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteLkRequesttype(LkRequesttype lkrequesttype)
        {
            _context.LkRequesttypes.Remove(lkrequesttype);
            await _context.SaveChangesAsync();
        }

    }
}
