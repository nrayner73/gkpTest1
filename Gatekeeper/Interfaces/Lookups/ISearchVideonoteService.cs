using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchVideonoteService
    {
        List<SearchVideoNotes> GetVideotnoteList(int fileid);
    }
}
