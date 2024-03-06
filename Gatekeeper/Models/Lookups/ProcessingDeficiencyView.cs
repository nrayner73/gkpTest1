using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models.Lookups
{
    [Keyless]
    public class ProcessingDeficiencyView
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public DateTime? Moddate { get; set; }

        public string? Moduser { get; set; }

        public DateTime? Createdate { get; set; }

        public string? Createuser { get; set; }

        public string? Status { get; set; }

        public string? SortBy { get; set; }
    }
}
