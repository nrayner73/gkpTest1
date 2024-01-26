using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchrequestfileService
    {
       List<Searchrequestfile> GetRequestfileList(Searchrequestfile searchfilter);
    }
}
