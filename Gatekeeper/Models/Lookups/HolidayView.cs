using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models.Lookups
{
    [Keyless]
    public class HolidayView
    {
        public int Id { get; set; }

        public string? HolidayYear { get; set; }

        public string? Holidayname { get; set; }

        public DateOnly? Holidaydate { get; set; }

        public DateTime? Moddate { get; set; }

        public string? Moduser { get; set; }

        public DateTime? Createdate { get; set; }

        public string? Createuser { get; set; }

        public string? Status { get; set; }
    }
}
