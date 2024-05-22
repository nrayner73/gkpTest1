using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces.Lookups;
using System.ComponentModel;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.DataServices.Lookups
{
    public class LkReviewtypeService : ILkReviewtypeService
    {
        private readonly AppDbContext _context;

        public LkReviewtypeService(AppDbContext context)
        {
            _context = context;
        }

        public List<LkReviewtype> GetLkReviewtypeList()
        {
            List<LkReviewtype> items = new List<LkReviewtype>();
            items = _context?.LkReviewtypes.ToList();
            items = items.Where(c => c.Status != "del").OrderBy(x => x.Sortby).ToList();
            return items;
        }

        public async Task<LkReviewtype> GetLkReviewtypeById(int id)
        {
            return await _context.LkReviewtypes
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkReviewtype> CreateLkReviewtype(LkReviewtype lkreviewtype)
        {
            _context.LkReviewtypes.Add(lkreviewtype);
            await _context.SaveChangesAsync();
            return lkreviewtype;
        }
        public async Task UpdateLkReviewtype(LkReviewtype lkreviewtype)
        {
            _context.LkReviewtypes.Update(lkreviewtype);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkReviewtype(LkReviewtype lkreviewtype)
        {
            lkreviewtype.Status = "del";
            _context.LkReviewtypes.Update(lkreviewtype);
            await _context.SaveChangesAsync();
        }

    }
}
