using System.Xml.Linq;

namespace Gatekeeper.Models
{
    public partial class AuditLog
    {
        public int Id { get; set; }

        public DateTime? AccessDate { get; set; }

        public string? UserName { get; set; }

        public string? AccessSystem { get; set; }

        public string? Activity { get; set; }

        public string? AccessNiche { get; set; }

        public string? ActivityXml { get; set; }

        public string? OccurrenceNo { get; set; }

        public string? RegNo { get; set; }

        public DateTime? Sdate { get; set; }
    }
}
