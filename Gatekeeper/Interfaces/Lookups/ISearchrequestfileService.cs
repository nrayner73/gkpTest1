using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchrequestfileService
    {
        Searchrequestfile GetRequestfileById(int fileid);
       List<Searchrequestfile> GetRequestfileList(Searchrequestfile searchfilter);
    }
}
