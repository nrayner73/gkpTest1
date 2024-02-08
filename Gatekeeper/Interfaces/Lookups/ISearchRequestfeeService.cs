using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchRequestfeeService
    {
        List<SearchRequestfee> GetRequestfeeList(int fileid);
    }
}
