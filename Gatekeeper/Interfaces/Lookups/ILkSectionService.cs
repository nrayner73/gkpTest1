using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILkSectionService
    {
        Task<IEnumerable<LkSection>> GetLkSectionsList();
        Task<LkSection> GetLkSectionById(int id);
        Task<LkSection> CreateLkSection(LkSection lksection);
        Task UpdateLkSection(LkSection lksection);
        Task DeleteLkSection(LkSection lksection);
    }
}
