using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchLkRequestStateService
    {
        List<SearchLkRequestState> GetLkRequestStateList();
    }
}
