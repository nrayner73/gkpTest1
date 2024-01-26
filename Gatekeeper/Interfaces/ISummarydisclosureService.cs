using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ISummarydisclosureService
    {
        Task<IEnumerable<Summarydisclosure>> GetSummarydisclosureList();
        Task<Summarydisclosure> GetSummarydisclosureById(int id);
        Task<Summarydisclosure> CreateSummarydisclosure(Summarydisclosure summarydisclosure);
        Task UpdateSummarydisclosure(Summarydisclosure summarydisclosure);
        Task DeleteSummarydisclosure(Summarydisclosure summarydisclosure);
    }
}
