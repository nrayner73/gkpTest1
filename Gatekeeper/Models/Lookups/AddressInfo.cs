using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models.Lookups
{
    [Keyless]
    public class AddressInfo
    {
        public string Street { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? Postalcode { get; set; }
        public string? Country { get; set; }
    }
}
