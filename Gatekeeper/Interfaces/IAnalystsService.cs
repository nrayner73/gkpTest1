using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IAnalystsService
    {
        Task<IEnumerable<Analyst>> GetAnalystsList();
        Task<Analyst> GetAnalystsById(int id);
        Task<Analyst> CreateAnalysts(Analyst analysts);
        Task UpdateAnalysts(Analyst analysts);
        Task DeleteAnalysts(Analyst analysts);
    }
}
