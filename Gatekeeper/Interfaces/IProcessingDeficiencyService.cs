using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IProcessingDeficiencyService
    {
        Task<IEnumerable<ProcessingDeficiency>> GetProcessingDeficiencyList();
       // Task<IEnumerable<ProcessingDeficiency>> CopyLastYearHoliday(string regno);
        Task<ProcessingDeficiency> GetProcessingDeficiencyById(int id);
        Task<ProcessingDeficiency> CreateProcessingDeficiency(ProcessingDeficiency processingDeficiency);
        Task UpdateProcessingDeficiency(ProcessingDeficiency processingDeficiency);
        Task DeleteProcessingDeficiency(ProcessingDeficiency processingDeficiency);
    }
}
