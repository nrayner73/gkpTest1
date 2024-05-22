using Gatekeeper.Models;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ILkReviewtypeService
    {
        List<LkReviewtype> GetLkReviewtypeList();
        Task<LkReviewtype> GetLkReviewtypeById(int id);
        Task<LkReviewtype> CreateLkReviewtype(LkReviewtype lkreviewtype);
        Task UpdateLkReviewtype(LkReviewtype lkreviewtype);
        Task DeleteLkReviewtype(LkReviewtype lkreviewtype);
    }
}
