using Gatekeeper.DataServices.Lookups;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchExtensionService
    {
        List<SearchExtension> GetExtensionList(int fileid);
    }
}
