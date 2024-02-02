using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface IDisclosureViewService
    {
        Task<IEnumerable<DisclosedViewitem>> GetDiscloseditemsList(int fileid);
    }
}
