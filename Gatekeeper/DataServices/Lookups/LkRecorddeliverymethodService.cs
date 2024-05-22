using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces.Lookups;

namespace Gatekeeper.DataServices.Lookups
{
    public class LkRecordDeliveryMethodService : ILkRecordDeliveryMethodService
    {
        private AppDbContext _context;

        public LkRecordDeliveryMethodService(AppDbContext context)
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
            var lastRecord = await _context?.LkRecorddeliverymethods.OrderByDescending(x => x.Sortby)
                .FirstOrDefaultAsync();

            if (lastRecord is not null)
            {
                lkrecorddeliverymethod.Sortby = lastRecord.Sortby + 1;
            }
            else
            {
                lkrecorddeliverymethod.Sortby = 1; //1st Record Delivery Method record
            }

            _context.LkRecorddeliverymethods.Add(lkrecorddeliverymethod);
            await _context.SaveChangesAsync();
            return lkrecorddeliverymethod;
        }
        public async Task UpdateLkRecorddeliverymethod(LkRecorddeliverymethod lkrecorddeliverymethod)
        {
            _context.LkRecorddeliverymethods.Update(lkrecorddeliverymethod);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLkRecorddeliverymethod(LkRecorddeliverymethod lkrecorddeliverymethod)
        {
            lkrecorddeliverymethod.Status = "del";
            _context.LkRecorddeliverymethods.Update(lkrecorddeliverymethod);
            await _context.SaveChangesAsync();
        }

    }
}
