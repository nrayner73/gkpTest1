using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface ILkPaymenttypeService
    {
        Task<IEnumerable<LkPaymenttype>> GetLkPaymentTypeList();
        
        Task<LkPaymenttype> GetLkPaymentTypeById(int id);
        
        Task<LkPaymenttype> CreateLkPaymentType(LkPaymenttype lkpaymenttype);
        
        Task UpdateLkPaymentType(LkPaymenttype lkpaymenttype);

        Task DeleteLkPaymentType(LkPaymenttype lkpaymenttype);
    }
}
