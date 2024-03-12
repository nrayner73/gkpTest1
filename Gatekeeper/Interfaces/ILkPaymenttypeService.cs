using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILkPaymenttypeService
    {
        Task<IEnumerable<LkPaymenttype>> GetLkPaymenttypeList();
        
        Task<LkPaymenttype> GetLkPaymenttypeById(int id);
        
        Task<LkPaymenttype> CreateLkPaymenttype(LkPaymenttype lkpaymenttype);
        
        Task UpdateLkPaymenttype(LkPaymenttype lkpaymenttype);

        Task DeleteLkPaymenttype(LkPaymenttype lkpaymenttype);
    }
}
