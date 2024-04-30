using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models.Lookups
{
    [Keyless]
    public class SearchLkRequestState
    {
        public int Id { get; set; }
        public string? Detail { get; set; }
        public DateTime? Createdate { get; set; }
        public string? Createuser { get; set; }
        public string? Status { get; set; }
        public int? Sortby { get; set; }

        public DateTime? Moddate { get; set; }
        public string? Moduser { get; set; }

    }
}
