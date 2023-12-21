using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILkProcessingdeficiencyService
    {
        Task<IEnumerable<LkProcessingdeficiency>> GetLkProcessingdeficiencyList();
        Task<LkProcessingdeficiency> GetLkProcessingdeficiencyById(int id);
        Task<LkProcessingdeficiency> CreateLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency);
        Task UpdateLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency);
        Task DeleteLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency);
    }
}
