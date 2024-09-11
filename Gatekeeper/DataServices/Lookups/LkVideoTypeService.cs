using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces.Lookups;
using static System.Collections.Specialized.BitVector32;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.DataServices.Lookups
{
    public class LkVideoTypeService : ILkVideoTypeService
    {
        private AppDbContext _context;

        public LkVideoTypeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkVideoType>> GetLkVideoTypeList()
        //public List<LkVideoType> GetLkVideoTypeList()
        {
            return await _context.LkVideoTypes
                   .ToListAsync();
        }

        public async Task<LkVideoType> GetLkVideoTypeById(int id)
        {
            return await _context.LkVideoTypes
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkVideoType> CreateLkVideoType(LkVideoType lkvideotype)
        {
            var lastRecord = await _context?.LkVideoTypes.OrderByDescending(x => x.Sortby)
                .FirstOrDefaultAsync();

            if (lastRecord is not null)
            {
                lkvideotype.Sortby = lastRecord.Sortby + 1;
            }
            else
            {
                lkvideotype.Sortby = 1; //1st Video Type record
            }

            _context.LkVideoTypes.Add(lkvideotype);
            await _context.SaveChangesAsync();
            return lkvideotype;
        }
        public async Task UpdateLkVideoType(LkVideoType lkvideotype)
        {
            _context.LkVideoTypes.Update(lkvideotype);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkVideoType(LkVideoType lkvideotype)
        {
            lkvideotype.Status = "del";
            _context.LkVideoTypes.Update(lkvideotype);
            await _context.SaveChangesAsync();
        }
    }
}
