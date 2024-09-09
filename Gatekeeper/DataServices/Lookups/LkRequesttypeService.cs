using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces.Lookups;

namespace Gatekeeper.DataServices.Lookups
{
    public class LkRequesttypeService : ILkRequesttypeService
    {
        private AppDbContext _context;

        public LkRequesttypeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkRequesttype>> GetLkRequesttypeList()
        {
            return await _context.LkRequesttypes.ToListAsync();
        }

        public async Task<LkRequesttype> GetLkRequesttypeById(int id)
        {
            return await _context.LkRequesttypes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkRequesttype> CreateLkRequesttype(LkRequesttype lkrequesttype)
        {
            var lastRecord = await _context?.LkRequesttypes.OrderByDescending(x => x.Sortby)
               .FirstOrDefaultAsync();

            if (lastRecord is not null)
            {
                lkrequesttype.Sortby = lastRecord.Sortby + 1;
            }
            else
            {
                lkrequesttype.Sortby = 1; //1st Request Type record
            }

            lkrequesttype.Refertype = lkrequesttype.Detail.Substring(0, 1);
            _context.LkRequesttypes.Add(lkrequesttype);
            await _context.SaveChangesAsync();
            return lkrequesttype;
        }
        public async Task UpdateLkRequesttype(LkRequesttype lkrequesttype)
        {
            _context.LkRequesttypes.Update(lkrequesttype);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkRequesttype(LkRequesttype lkrequesttype)
        {
            lkrequesttype.Status = "del"; //mark as inactive
            _context.LkRequesttypes.Update(lkrequesttype);
            await _context.SaveChangesAsync();
        }

    }
}
