using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILocationitemsService
    {
        Task<IEnumerable<Locationitem>> GetLocationitemList();
        Task<Locationitem> GetLocationitemById(int id);
        Task<Locationitem> GetLocationitemByLocationId(int locationid,int fileid);
        Task<Locationitem> CreateLocationitem(Locationitem locationitem);
        Task UpdateLocationitem(Locationitem locationitem);
        Task DeleteLocationitem(Locationitem locationitem);
    }
}
