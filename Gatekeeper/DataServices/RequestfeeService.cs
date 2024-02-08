using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using GateKeeper.Models;

namespace Gatekeeper.Services
{
    public class RequestfeeService : IRequestfeeService
    {
        private AppDbContext _context;

        public RequestfeeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Requestfee>> GetRequestfeeList(int fileid)
        {
            return await _context.Requestfees.Where(x=>x.Requestid==fileid)
                    .ToListAsync();
        }
    
        public async Task<Requestfee> GetRequestfeeById(int id)
        {
            return await _context.Requestfees
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Requestfee> CreateRequestfee(Requestfee requestfee)
        {
            _context.Requestfees.Add(requestfee);
            await _context.SaveChangesAsync();
            return requestfee;
        }
        public async System.Threading.Tasks.Task UpdateRequestfee(Requestfee requestfee)
        {
            _context.Requestfees.Update(requestfee);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteRequestfee(Requestfee requestfee)
        {
            _context.Requestfees.Remove(requestfee);
            await _context.SaveChangesAsync();
        }

    }
}
