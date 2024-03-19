using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class AlltaskService : IAlltaskService
    {
        private AppDbContext _context;

        public AlltaskService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Alltask>> GetAlltaskList()
        {
            return await _context.Alltasks
                    .ToListAsync();
        }
    
        public async Task<Alltask> GetAlltaskById(int id)
        {
            return await _context.Alltasks
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Alltask> CreateAlltask(Alltask alltask)
        {
            _context.Alltasks.Add(alltask);
            await _context.SaveChangesAsync();
            return alltask;
        }
        public async System.Threading.Tasks.Task UpdateAlltask(Alltask alltask)
        {
            _context.Alltasks.Update(alltask);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteAlltask(Alltask alltask)
        {
            _context.Alltasks.Remove(alltask);
            await _context.SaveChangesAsync();
        }

    }
}

