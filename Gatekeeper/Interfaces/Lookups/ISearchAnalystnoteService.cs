using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchAnalystnoteService
    {
        List<SearchAnalystNotes> GetAnalystnoteList(int fileid);
    }
}
