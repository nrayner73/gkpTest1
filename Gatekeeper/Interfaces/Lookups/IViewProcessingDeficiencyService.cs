using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface IViewProcessingDeficiencyService
    {
        List<ProcessingDeficiencyView> GetProcessingDeficiencyList();
    }
}
