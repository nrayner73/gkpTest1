using Gatekeeper.Models;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ILkRecordDeliveryMethodService
    {
        Task<IEnumerable<LkRecorddeliverymethod>> GetLkRecorddeliverymethodList();
        Task<LkRecorddeliverymethod> GetLkRecorddeliverymethodById(int id);
        Task<LkRecorddeliverymethod> CreateLkRecorddeliverymethod(LkRecorddeliverymethod lkrecorddeliverymethod);
        Task UpdateLkRecorddeliverymethod(LkRecorddeliverymethod lkrecorddeliverymethod);
        Task DeleteLkRecorddeliverymethod(LkRecorddeliverymethod lkrecorddeliverymethod);
    }
}
