using Gatekeeper.Models;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Interfaces.Lookups
{
    public interface ILookupService
    {
        Task<IEnumerable<LkSection>> GetLkSectionsList();
       

    }
}
