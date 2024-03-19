using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class LkRecorddeliverymethodService : ILkRecorddeliverymethodService
    {
        private AppDbContext _context;

        public LkRecorddeliverymethodService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LkRecorddeliverymethod>> GetLkRecorddeliverymethodList()
        {
            return await _context.LkRecorddeliverymethods
                    .ToListAsync();
        }
    
        public async Task<LkRecorddeliverymethod> GetLkRecorddeliverymethodById(int id)
        {
            return await _context.LkRecorddeliverymethods
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<LkRecorddeliverymethod> CreateLkRecorddeliverymethod(LkRecorddeliverymethod lkrecorddeliverymethod)
        {
            _context.LkRecorddeliverymethods.Add(lkrecorddeliverymethod);
            await _context.SaveChangesAsync();
            return lkrecorddeliverymethod;
        }
        public async System.Threading.Tasks.Task UpdateLkRecorddeliverymethod(LkRecorddeliverymethod lkrecorddeliverymethod)
        {
            _context.LkRecorddeliverymethods.Update(lkrecorddeliverymethod);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteLkRecorddeliverymethod(LkRecorddeliverymethod lkrecorddeliverymethod)
        {
            _context.LkRecorddeliverymethods.Remove(lkrecorddeliverymethod);
            await _context.SaveChangesAsync();
        }

    }
}
