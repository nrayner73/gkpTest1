using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchLkLocationService
    {
        List<SearchLkLocation> GetLkLocationList();
               
    }
}
