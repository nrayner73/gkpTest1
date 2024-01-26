using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces
{
    public interface IAnalystnoteService
    {
        Task<IEnumerable<Analystnote>> GetAnalystnoteList(int fileid);
        //List<SearchAnalystNotes> GetAnalystnoteList(int fileid);
        Task<Analystnote> GetAnalystnoteById(int id);
        Task<Analystnote> CreateAnalystnote(Analystnote analystnote);
        Task UpdateAnalystnote(Analystnote analystnote);
        Task DeleteAnalystnote(Analystnote analystnote);
    }
}
