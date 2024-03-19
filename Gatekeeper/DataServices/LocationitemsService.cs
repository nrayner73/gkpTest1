using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class LocationitemsService : ILocationitemsService
    {
        private AppDbContext _context;

        public LocationitemsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Locationitem>> GetLocationitemList()
        {
            return await _context.Locationitems
                    .ToListAsync();
        }
    
        public async Task<Locationitem> GetLocationitemById(int id)
        {
            return await _context.Locationitems
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Locationitem> GetLocationitemByLocationId(int locationid,int fileid)
        {
            Locationitem locationitem = new Locationitem();

            locationitem = await _context.Locationitems.FirstOrDefaultAsync(x => x.Locationid == locationid && x.Requestid == fileid);
            //return await _context.Locationitems
            //    .FirstOrDefaultAsync(x => x.Id == id);

            return locationitem;
        }

        public async Task<Locationitem> CreateLocationitem(Locationitem locationitem)
        {
            _context.Locationitems.Add(locationitem);
            await _context.SaveChangesAsync();
            return locationitem;
        }
        public async System.Threading.Tasks.Task UpdateLocationitem(Locationitem locationitem)
        {
            _context.Locationitems.Update(locationitem);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteLocationitem(Locationitem locationitem)
        {
            _context.Locationitems.Remove(locationitem);
            await _context.SaveChangesAsync();
        }

    }
}
