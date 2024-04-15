using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILkLocationService
    {
        Task<IEnumerable<LkLocation>> GetLkLocationList();
       
        Task<LkLocation> GetLkLocationById(int id);
        Task<LkLocation> CreateLkLocation(LkLocation lkLocation);
        Task UpdateLkLocation(LkLocation lkLocation);
        Task DeleteLkLocation(LkLocation lkLocation);
    }
}
