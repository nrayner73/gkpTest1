using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILkLocationService
    {
        Task<IEnumerable<LkLocationsearch>> GetLkLocationList();
       
        Task<LkLocationsearch> GetLkLocationById(int id);
        Task<LkLocationsearch> CreateLkLocation(LkLocationsearch lkLocation);
        Task UpdateLkLocation(LkLocationsearch lkLocation);
        Task DeleteLkLocation(LkLocationsearch lkLocation);
    }
}
