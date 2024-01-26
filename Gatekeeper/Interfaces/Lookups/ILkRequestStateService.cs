using Gatekeeper.Models;

namespace Gatekeeper.Interfaces.Lookups
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
