using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces
{
    public interface IAnalystService
    {
        List<Analyst> GetAnalystsList();
        Task<Analyst> GetAnalystById(int id);
        Task<Analyst> CreateAnalyst(Analyst analyst);
        Task UpdateAnalyst(Analyst analyst);
        Task DeleteAnalyst(Analyst analyst);
    }
}
