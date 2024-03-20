using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchLkPaymentTypeService
    {
        List<SearchLkPaymentTypes> GetLkPaymentTypeList();
    }
}
