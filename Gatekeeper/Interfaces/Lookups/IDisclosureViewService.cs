using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface IDisclosureViewService
    {
        Task<IEnumerable<DisclosedViewitem>> GetDiscloseditemsList(int fileid);
        Task<IEnumerable<Summarydisclosure>> GetDisclosureSummary(int fileid);
        Task<IEnumerable<LocationViewitem>> GetLocationitemsList(int fileid);
    }
}
