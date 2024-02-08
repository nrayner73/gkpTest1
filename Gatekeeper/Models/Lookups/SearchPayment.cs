namespace Gatekeeper.Models.Lookups
{
    public class SearchPayment
    {
        public int Id { get; set; }

        public int? Requestid { get; set; }

        public string? Description { get; set; }

        public DateTime? Paymentdate { get; set; }

        public int? Paytypeid { get; set; }

        public string? Paytype { get; set; }

        public string? Authorization { get; set; }

        public decimal? Payamount { get; set; }

        public DateTime? Createdate { get; set; }

        public string? Createuser { get; set; }

        public DateTime? Moddate { get; set; }

        public string? Moduser { get; set; }

        public string? Status { get; set; }
    }
}
