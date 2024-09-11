using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ILkVideoTypeService
    {
        //public List<LkVideoType> GetLkVideoTypeList();
        Task<IEnumerable<LkVideoType>> GetLkVideoTypeList();
        Task<LkVideoType> GetLkVideoTypeById(int id);
        Task<LkVideoType> CreateLkVideoType(LkVideoType lkvideotype);
        Task UpdateLkVideoType(LkVideoType lkvideotype);
        Task DeleteLkVideoType(LkVideoType lkvideotype);
    }
}
