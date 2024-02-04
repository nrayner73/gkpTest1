using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class VideonoteService : IVideonoteService
    {
        private AppDbContext _context;

        public VideonoteService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Videonote>> GetVideonoteList(int fileid)
        {
            return await _context.Videonotes
                    .ToListAsync();
        }
    
        public async Task<Videonote> GetVideonoteById(int id)
        {
            return await _context.Videonotes
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Videonote> CreateVideonote(Videonote videonote)
        {
            _context.Videonotes.Add(videonote);
            await _context.SaveChangesAsync();
            return videonote;
        }
        public async System.Threading.Tasks.Task UpdateVideonote(Videonote videonote)
        {
            _context.Videonotes.Update(videonote);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteVideonote(Videonote videonote)
        {
            _context.Videonotes.Remove(videonote);
            await _context.SaveChangesAsync();
        }

    }
}
