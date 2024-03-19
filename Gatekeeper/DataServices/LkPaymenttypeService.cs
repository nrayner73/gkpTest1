using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class LkPaymenttypeService : ILkPaymenttypeService
    {
        private AppDbContext _context;

        public LkPaymenttypeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkPaymenttype>> GetLkPaymenttypeList()
        {
            return await _context.LkPaymenttypes.ToListAsync();
        }
    
        public async Task<LkPaymenttype> GetLkPaymenttypeById(int id)
        {
            return await _context.LkPaymenttypes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkPaymenttype> CreateLkPaymenttype(LkPaymenttype lkpaymenttype)
        {
            _context.LkPaymenttypes.Add(lkpaymenttype);
            await _context.SaveChangesAsync();
            return lkpaymenttype;
        }
        public async System.Threading.Tasks.Task UpdateLkPaymenttype(LkPaymenttype lkpaymenttype)
        {
            _context.LkPaymenttypes.Update(lkpaymenttype);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteLkPaymenttype(LkPaymenttype lkpaymenttype)
        {
            _context.LkPaymenttypes.Remove(lkpaymenttype);
            await _context.SaveChangesAsync();
        }

    }
}
