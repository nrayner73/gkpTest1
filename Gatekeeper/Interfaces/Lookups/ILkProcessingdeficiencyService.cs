using Gatekeeper.Models;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ILkProcessingdeficiencyService
    {
        List<LkProcessingdeficiency> GetLkProcessingdeficiencyList();
        Task<LkProcessingdeficiency> GetLkProcessingdeficiencyById(int id);
        Task<LkProcessingdeficiency> CreateLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency);
        Task UpdateLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency);
        Task DeleteLkProcessingdeficiency(LkProcessingdeficiency lkprocessingdeficiency);
    }
}
