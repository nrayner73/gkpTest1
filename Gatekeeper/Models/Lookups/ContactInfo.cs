using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models.Lookups
{
    [Keyless]
    public class ContactInfo
    {
        public string contactinfo { get; set; }
    }
}
