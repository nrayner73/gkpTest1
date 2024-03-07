namespace Gatekeeper.Models.Lookups
{
    public class LocationViewitem
    {
        public int Id { get; set; }

        public int Requestid { get; set; }

        public int Locationid { get; set; }

        public string? Locationname { get; set; }

        public DateTime? Createdate { get; set; }

        public string? Createuser { get; set; }

        public string? Status { get; set; }

    }
}
