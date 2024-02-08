using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ISearchPaymentService
    {
        List<SearchPayment> GetPaymentList(int fileid);
    }
}
