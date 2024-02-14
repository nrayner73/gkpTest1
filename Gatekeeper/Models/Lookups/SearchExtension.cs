namespace Gatekeeper.Models.Lookups
{
    public class SearchExtension
    {

        public int Id { get; set; }

        public int? Requestid { get; set; }

        public int? Extensionid { get; set; }

        public string? Extension { get; set; }

        public int? Sectionid { get; set; }

        public string? Section { get; set; }

        public DateTime? Extensiondate { get; set; }

        public int? Dayamount { get; set; }

        public DateTime? Createdate { get; set; }

        public string? Createuser { get; set; }

        public DateTime? Moddate { get; set; }

        public string? Moduser { get; set; }

        public string? Status { get; set; }
    }
}
