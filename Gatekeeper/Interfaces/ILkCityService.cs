using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILkCityService
    {
        Task<IEnumerable<LkCity>> GetLkCityList();
        
        Task<LkCity> GetLkCityById(int id);
        
        Task<LkCity> CreateLkCity(LkCity lkcity);
        
        Task UpdateLkCity(LkCity lkcity);

        Task DeleteLkCity(LkCity lkcity);
    }
}
