using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;

namespace Gatekeeper.Services
{
    public class DiscloseditemsService : IDiscloseditemsService
    {
        private AppDbContext _context;
       

        public DiscloseditemsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Discloseditem>> GetDiscloseditemsList(int fileid)
        {
            return await _context.Discloseditems.Where(x => x.Requestid == fileid)
                    .ToListAsync();
        }

        public async Task<Discloseditem> GetDiscloseditemsBySectionId(int sectionid,int fileid)
        {
            return await _context.Discloseditems
                .FirstOrDefaultAsync(x => x.Sectionid == sectionid && x.Requestid == fileid);
        }

        public async Task<Discloseditem> GetDiscloseditemsById(int id)
        {
            return await _context.Discloseditems
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Discloseditem> CreateDiscloseditems(Discloseditem discloseditems)
        {
            _context.Discloseditems.Add(discloseditems);
            await _context.SaveChangesAsync();
            return discloseditems;
        }
        public async System.Threading.Tasks.Task UpdateDiscloseditems(Discloseditem discloseditems)
        {
            _context.Discloseditems.Update(discloseditems);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteDiscloseditems(Discloseditem discloseditems)
        {
            _context.Discloseditems.Remove(discloseditems);
            await _context.SaveChangesAsync();
        }

    }
}
