using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class SummarydisclosureService : ISummarydisclosureService
    {
        private AppDbContext _context;

        public SummarydisclosureService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Summarydisclosure>> GetSummarydisclosureList()
        {
            return await _context.Summarydisclosures
                    .ToListAsync();
        }
    
        public async Task<Summarydisclosure> GetSummarydisclosureById(int id)
        {
            return await _context.Summarydisclosures
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Summarydisclosure> CreateSummarydisclosure(Summarydisclosure summarydisclosure)
        {
            _context.Summarydisclosures.Add(summarydisclosure);
            await _context.SaveChangesAsync();
            return summarydisclosure;
        }
        public async System.Threading.Tasks.Task UpdateSummarydisclosure(Summarydisclosure summarydisclosure)
        {
            _context.Summarydisclosures.Update(summarydisclosure);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteSummarydisclosure(Summarydisclosure summarydisclosure)
        {
            _context.Summarydisclosures.Remove(summarydisclosure);
            await _context.SaveChangesAsync();
        }

    }
}
