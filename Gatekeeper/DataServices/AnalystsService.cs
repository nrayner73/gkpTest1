using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.DataServices
{
    public class AnalystsService : IAnalystsService
    {
        private AppDbContext _context;

        public AnalystsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Analyst>> GetAnalystsList()
        {
            return await _context.Analysts
                    .ToListAsync();
        }
    
        public async Task<Analyst> GetAnalystsById(int id)
        {
            return await _context.Analysts
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Analyst> CreateAnalysts(Analyst analysts)
        {
            _context.Analysts.Add(analysts);
            await _context.SaveChangesAsync();
            return analysts;
        }
        public async System.Threading.Tasks.Task UpdateAnalysts(Analyst analysts)
        {
            _context.Analysts.Update(analysts);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteAnalysts(Analyst analysts)
        {
            _context.Analysts.Remove(analysts);
            await _context.SaveChangesAsync();
        }

    }
}
