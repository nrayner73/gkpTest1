using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.DataServices
{
    public class LkPaymenttypeService : ILkPaymenttypeService
    {
        private AppDbContext _context;

        public LkPaymenttypeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkPaymenttype>> GetLkPaymentTypeList()
        {
            return await _context.LkPaymenttypes.ToListAsync();
        }

        public async Task<LkPaymenttype> GetLkPaymentTypeById(int id)
        {
            return await _context.LkPaymenttypes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkPaymenttype> CreateLkPaymentType(LkPaymenttype lkpaymenttype)
        {
            _context.LkPaymenttypes.Add(lkpaymenttype);
            await _context.SaveChangesAsync();
            return lkpaymenttype;
        }
        public async Task UpdateLkPaymentType(LkPaymenttype lkpaymenttype)
        {
            _context.LkPaymenttypes.Update(lkpaymenttype);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkPaymentType(LkPaymenttype lkpaymenttype)
        {
            _context.LkPaymenttypes.Remove(lkpaymenttype);
            await _context.SaveChangesAsync();
        }

    }
}
