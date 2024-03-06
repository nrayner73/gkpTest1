using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Microsoft.Data.SqlClient;
using Gatekeeper.Interfaces;

namespace Gatekeeper.DataServices
{
    public class ProcessingDeficiencyService : IProcessingDeficiencyService
    {
        private AppDbContext _context;

        public ProcessingDeficiencyService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProcessingDeficiency>> GetProcessingDeficiencyList()
        {
            List<ProcessingDeficiency> items = new List<ProcessingDeficiency>();

            items = await _context.ProcessingDeficiencies.ToListAsync();


            return items;
        }

        public async Task<ProcessingDeficiency> GetProcessingDeficiencyById(int id)
        {
            return await _context.ProcessingDeficiencies
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ProcessingDeficiency> CreateProcessingDeficiency(ProcessingDeficiency processingDeficiency)
        {
            _context.ProcessingDeficiencies.Add(processingDeficiency);
            await _context.SaveChangesAsync();
            return processingDeficiency;
        }
        public async Task UpdateProcessingDeficiency(ProcessingDeficiency processingDeficiency)
        {
            _context.ProcessingDeficiencies.Update(processingDeficiency);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProcessingDeficiency(ProcessingDeficiency processingDeficiency)
        {
            _context.ProcessingDeficiencies.Remove(processingDeficiency);
            await _context.SaveChangesAsync();
        }

    }
}
