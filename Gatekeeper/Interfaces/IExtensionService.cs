using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IExtensionService
    {
        Task<IEnumerable<Extension>> GetExtensionList(int fileid);
        Task<Extension> GetExtensionById(int id);
        Task<Extension> CreateExtension(Extension extensions);
        Task UpdateExtension(Extension extensions);
        Task DeleteExtension(Extension extensions);
    }
}
