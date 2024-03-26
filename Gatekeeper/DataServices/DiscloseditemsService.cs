using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;

namespace Gatekeeper.DataServices
{
    public class DiscloseditemsService : IDiscloseditemsService
    {
        private AppDbContext _context;
       

        public DiscloseditemsService(AppDbContext context)
        {

            //_context.Database.CloseConnection();
            //_context.Database.OpenConnection();
      
            _context = context;

            


        }

       

        public async Task<IEnumerable<Discloseditem>> GetDiscloseditemsList(int fileid)
        {
            List<Discloseditem> discloseditems = new List<Discloseditem>();

           var items =  await _context.Discloseditems
                    .ToListAsync();

            if (fileid > 0)
            {
                discloseditems = items.Where(x=>x.Requestid.Equals(fileid)).ToList();
            }

          //  _context.Entry(discloseditems).Reload();

            return discloseditems;
        }

        public async Task<Discloseditem> GetDiscloseditemsBySectionId(int sectionid,int fileid)
        {
            Discloseditem discloseditem = new Discloseditem();

            discloseditem = await _context.Discloseditems
                .FirstOrDefaultAsync(x => x.Sectionid == sectionid && x.Requestid == fileid);

           // _context.Entry(discloseditem).Reload();

            return discloseditem;


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
