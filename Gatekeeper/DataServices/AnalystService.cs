using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.DataServices
{
    public class AnalystService : IAnalystService
    {
        private AppDbContext _context;

        public AnalystService(AppDbContext context)
        {
            _context = context;
        }

        public List<Analyst> GetAnalystsList()
        {
            List<Analyst> items = new List<Analyst>();
            items = _context?.Analysts.FromSqlRaw("exec [gkp].[GetAnalysts]").ToList();

            items = items.Where(c => c.Status != "del").ToList();

            return items;
        }

        public async Task<Analyst> GetAnalystById(int id)
        {
            return await _context.Analysts
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Analyst> CreateAnalyst(Analyst analyst)
        {
            var lastRecord = await _context?.Analysts.OrderByDescending(x => x.Sortby)
                .FirstOrDefaultAsync();

            if (lastRecord is not null)
            {
                analyst.Sortby = lastRecord.Sortby + 1;
            }
            else
            {
                analyst.Sortby = 1; //1st Request State record
            }
            
            _context.Analysts.Add(analyst);
            await _context.SaveChangesAsync();
            return analyst;
        }
        public async System.Threading.Tasks.Task UpdateAnalyst(Analyst analyst)
        {
            _context.Analysts.Update(analyst);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteAnalyst(Analyst analyst)
        {
            analyst.Status = "del"; 
            _context.Analysts.Update(analyst);
            await _context.SaveChangesAsync();
        }

    }
}
