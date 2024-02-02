using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces
{
    public interface IDiscloseditemsService
    {
        Task<IEnumerable<Discloseditem>> GetDiscloseditemsList(int fileid);
        Task<Discloseditem> GetDiscloseditemsById(int id);
        Task<Discloseditem> CreateDiscloseditems(Discloseditem discloseditems);
        Task UpdateDiscloseditems(Discloseditem discloseditems);
        Task DeleteDiscloseditems(Discloseditem discloseditems);
    }
}
