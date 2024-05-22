using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using static System.Collections.Specialized.BitVector32;


namespace Gatekeeper.DataServices
{
    public class ExtensionService : IExtensionService
    {
        private AppDbContext _context;

        public ExtensionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Extension>> GetExtensionList(int fileid)
        {
            return await _context.Extensions.Where(x=>x.Requestid==fileid)
                    .ToListAsync();
        }

        

        public async Task<Extension> GetExtensionById(int id)
        {
            return await _context.Extensions
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Extension> CreateExtension(Extension extension)
        {
            _context.Extensions.Add(extension);
            await _context.SaveChangesAsync();
            return extension;
        }
        public async System.Threading.Tasks.Task UpdateExtension(Extension extension)
        {
            _context.Extensions.Update(extension);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteExtension(Extension extension)
        {
            extension.Status = "del";
            _context.Extensions.Update(extension);
            await _context.SaveChangesAsync();
        }

    }

}
