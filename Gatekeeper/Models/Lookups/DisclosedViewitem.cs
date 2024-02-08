using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models.Lookups
{
    [Keyless]
    public class DisclosedViewitem
    {

        public int Id { get; set; }

        public int Requestid { get; set; }

        public int Sectionid { get; set; }

        public string? Section { get; set; }

        public string? Sectiontype { get; set; }

        public string? Othertext { get; set; }

        public DateTime? Createdate { get; set; }

        public string? Createuser { get; set; }

        public string? Status { get; set; }
    }
}
