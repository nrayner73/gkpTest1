using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IRequestfileService
    {
        Task<IEnumerable<Requestfile>> GetRequestfileList();
        Task<Requestfile> GetRequestfileById(int id);
        Task<Requestfile> CreateRequestfile(Requestfile requestfile);
        Task UpdateRequestfile(Requestfile requestfile);
        Task DeleteRequestfile(Requestfile requestfile);
       
    }
}
