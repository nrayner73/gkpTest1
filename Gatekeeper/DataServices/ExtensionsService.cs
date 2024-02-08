using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;


namespace Gatekeeper.DataServices
{
    public class ExtensionsService : IExtensionsService
    {
        private AppDbContext _context;

        public ExtensionsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Extension>> GetExtensionsList(int fileid)
        {
            return await _context.Extensions
                    .ToListAsync();
        }

        public async Task<Extension> GetExtensionsById(int id)
        {
            return await _context.Extensions
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Extension> CreateExtensions(Extension extension)
        {
            _context.Extensions.Add(extension);
            await _context.SaveChangesAsync();
            return extension;
        }
        public async System.Threading.Tasks.Task UpdateExtensions(Extension extension)
        {
            _context.Extensions.Update(extension);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteExtensions(Extension extension)
        {
            _context.Extensions.Remove(extension);
            await _context.SaveChangesAsync();
        }

    }

}
