using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IAlltaskService
    {
        Task<IEnumerable<Alltask>> GetAlltaskList();
        Task<Alltask> GetAlltaskById(int id);
        Task<Alltask> CreateAlltask(Alltask alltask);
        Task UpdateAlltask(Alltask alltask);
        Task DeleteAlltask(Alltask alltask);
    }
}
