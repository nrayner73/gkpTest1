using Gatekeeper.Models;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ILkExtensionService
    {
        Task<IEnumerable<LkExtension>> GetLkExtensionList();
        Task<LkExtension> GetLkExtensionById(int id);
        Task<LkExtension> CreateLkExtension(LkExtension lkextension);
        Task UpdateLkExtension(LkExtension lkextension);
        Task DeleteLkExtension(LkExtension lkextension);
    }
}
