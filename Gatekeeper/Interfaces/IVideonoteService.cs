using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IVideonoteService
    {
        Task<IEnumerable<Videonote>> GetVideonoteList(int fileid);
        Task<Videonote> GetVideonoteById(int id);
        Task<Videonote> CreateVideonote(Videonote videonote);
        Task UpdateVideonote(Videonote videonote);
        Task DeleteVideonote(Videonote videonote);
    }
}
