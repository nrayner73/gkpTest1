using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILkSectionsService
    {
        Task<IEnumerable<LkSection>> GetLkSectionsList();
        Task<LkSection> GetLkSectionsById(int id);
        Task<LkSection> CreateLkSections(LkSection lksections);
        Task UpdateLkSections(LkSection lksections);
        Task DeleteLkSections(LkSection lksections);
    }
}
