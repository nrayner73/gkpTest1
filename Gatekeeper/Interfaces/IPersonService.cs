using Gatekeeper.Models;
using System.Threading.Tasks;

namespace Gatekeeper.Interfaces
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetPersonList();
        Task<Person> GetPersonById(int id);
        Task<Person> CreatePerson(Person person);
        Task UpdatePerson(Person person);
        Task DeletePerson(Person person);
    }
}
