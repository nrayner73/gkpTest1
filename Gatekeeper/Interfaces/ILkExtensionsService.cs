using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILkExtensionsService
    {
        Task<IEnumerable<LkExtension>> GetLkExtensionsList();
        Task<LkExtension> GetLkExtensionsById(int id);
        Task<LkExtension> CreateLkExtensions(LkExtension lkextensions);
        Task UpdateLkExtensions(LkExtension lkextensions);
        Task DeleteLkExtensions(LkExtension lkextensions);
    }
}
