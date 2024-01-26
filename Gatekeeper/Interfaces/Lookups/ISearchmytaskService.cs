using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchmytaskService
    {
        List<Searchmytask> GetMytaskList(Searchmytask searchfilter);
    }
}
