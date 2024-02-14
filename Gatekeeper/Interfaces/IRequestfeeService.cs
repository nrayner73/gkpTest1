using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IRequestfeeService
    {
        Task<IEnumerable<Requestfee>> GetRequestfeeList(int fileid);
        Task<Requestfee> GetRequestfeeById(int id);
        Task<Requestfee> CreateRequestfee(Requestfee requestfee);
        Task UpdateRequestfee(Requestfee requestfee);
        Task DeleteRequestfee(Requestfee requestfee);
    }
}
