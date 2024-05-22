using Gatekeeper.Models;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ILkRequesttypeService
    {
        List<LkRequesttype> GetLkRequesttypeList();
        Task<LkRequesttype> GetLkRequesttypeById(int id);
        Task<LkRequesttype> CreateLkRequesttype(LkRequesttype lkrequesttype);
        Task UpdateLkRequesttype(LkRequesttype lkrequesttype);
        Task DeleteLkRequesttype(LkRequesttype lkrequesttype);
    }
}
