using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using static System.Collections.Specialized.BitVector32;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using System.Net.NetworkInformation;

namespace Gatekeeper.DataServices
{
    public class LkSectionService : ILkSectionService
    {
        private AppDbContext _context;

        public LkSectionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkSection>> GetLkSectionsList()
        {
            return await _context.LkSections
                    .ToListAsync();
        }

        public async Task<LkSection> GetLkSectionById(int id)
        {
            return await _context.LkSections
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkSection> CreateLkSection(LkSection lksection)
        {
            var lastRecord = await _context?.LkSections.OrderByDescending(x => x.Sortby)
                .FirstOrDefaultAsync(x => x.Sectiontype == lksection.Sectiontype);
            
            if (lastRecord is not null)
            {
                lksection.Sortby = lastRecord.Sortby + 1;
            }
            else
            {
                lksection.Sortby = 1; //1st Section in that Section type
            }

            _context.LkSections.Add(lksection);
                       
            await _context.SaveChangesAsync();
           
            return lksection;
        }
        public async Task UpdateLkSection(LkSection lksection)
        {
            _context.LkSections.Update(lksection);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkSection(LkSection lksection)
        {
            lksection.Status = "del"; 
            _context.LkSections.Update(lksection);
            await _context.SaveChangesAsync();
        }

    }
}
