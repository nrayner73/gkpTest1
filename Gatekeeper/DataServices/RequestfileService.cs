using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using System;
using System.Diagnostics.Eventing.Reader;

namespace Gatekeeper.Services
{
    public class RequestfileService : IRequestfileService
    {
        private AppDbContext _context;

        public RequestfileService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Requestfile>> GetRequestfileList()
        {
            return await _context.Requestfiles
                    .ToListAsync();
        }
    
        public async Task<Requestfile> GetRequestfileById(int id)
        {
            return await _context.Requestfiles
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Requestfile> CreateRequestfile(Requestfile requestfile)
        {
            _context.Requestfiles.Add(requestfile);
            await _context.SaveChangesAsync();
            return requestfile;
        }

        public async System.Threading.Tasks.Task UpdateRequestfile(Requestfile requestfile)
        {
            _context.Update(requestfile);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteRequestfile(Requestfile requestfile)
        {
            _context.Requestfiles.Remove(requestfile);
            await _context.SaveChangesAsync();
        }
    }
}

