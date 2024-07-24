using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;

namespace Gatekeeper.Interfaces
{
    public interface IRequestfileService
    {
        Requestfile CreateRequestFileFromForm(AccessRequestForm accessRequestForm);
        Task<IEnumerable<Requestfile>> GetRequestfileList(Searchrequestfile searchfilter);
        //Task<IEnumerable<Requestfile>> GetRequestfileList();
        Task<Requestfile> GetRequestfileById(int id);
        Task<Requestfile> CreateRequestfile(Requestfile requestfile);
        Task UpdateRequestfile(Requestfile requestfile);
        Task DeleteRequestfile(Requestfile requestfile);
       
    }
}
