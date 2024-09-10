using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchAnalystService
    {
        List<SearchAnalyst> GetAnalystsList();
    }
}
