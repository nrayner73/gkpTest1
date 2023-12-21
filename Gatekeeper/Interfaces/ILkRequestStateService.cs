using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILkRequestStateService
    {
        Task<IEnumerable<LkRequeststate>> GetLkRequestStateList();
        Task<LkRequeststate> GetLkRequestStateById(int id);
        Task<LkRequeststate> CreateLkRequestState(LkRequeststate lkrequeststate);
        Task UpdateLkRequestState(LkRequeststate lkrequeststate);
        Task DeleteLkRequestState(LkRequeststate lkrequeststate);
    }
}
