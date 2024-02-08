using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IExtensionsService
    {
        Task<IEnumerable<Extension>> GetExtensionsList(int fileid);
        Task<Extension> GetExtensionsById(int id);
        Task<Extension> CreateExtensions(Extension extensions);
        Task UpdateExtensions(Extension extensions);
        Task DeleteExtensions(Extension extensions);
    }
}
