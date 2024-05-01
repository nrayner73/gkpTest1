using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces.Lookups;
using System.ComponentModel;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.DataServices.Lookups
{
    public class LkRequesttypeService : ILkRequesttypeService
    {
        private readonly AppDbContext _context;

        public LkRequesttypeService(AppDbContext context)
        {
            _context = context;
        }

        public List<LkRequesttype> GetLkRequesttypeList()
        {
            List<LkRequesttype> items = new List<LkRequesttype>();
            items = _context?.LkRequesttypes.ToList();
            items = items.Where(c => c.Status != "del").OrderBy(x => x.Sortby).ToList();
            return items;
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
        public async Task UpdateLkRequesttype(LkRequesttype lkrequesttype)
        {
            _context.LkRequesttypes.Update(lkrequesttype);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkRequesttype(LkRequesttype lkrequesttype)
        {
            lkrequesttype.Status = "del";
            _context.LkRequesttypes.Update(lkrequesttype);
            await _context.SaveChangesAsync();
        }

    }
}
