using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models.Lookups
{
    [Keyless]
    public class Searchrequestfile
    {
        public int Id { get; set; }
        public int? Yearid { get; set; }
        public int? Fileyear { get; set; }
        public string? Filenumber { get; set; } = string.Empty;
        public DateOnly? Requestdate { get; set; }
        public DateOnly ? Receivedate { get; set; }
        public DateOnly ? Requestduedate { get; set; }
        public string? Referencenumber { get; set; } = string.Empty;
        public int? Requesttypeid { get; set; }
        public string? Requesttype { get; set; } = string.Empty;
        public string? Analystassigned { get; set; } = string.Empty;
        public int? Analystassignedid { get; set; } 
        public string? Requeststate { get; set; } = string.Empty;
        public int? Requeststateid { get; set; } 
        public DateOnly? Closedate { get; set; }
        public int? PersonId { get; set; }
        public string? Firstname { get; set; } = string.Empty;
        public string? Lastname { get; set; } = string.Empty;
        public string? Middlename { get; set; } = string.Empty;
        public string? Personname { get; set; } = string.Empty;
        public string? PersonOfInterest { get; set; } = string.Empty;
        public string? POIfirstname { get; set; } = string.Empty;
        public string? POIlastname { get; set; } = string.Empty;
        public string? POImiddlename { get; set; } = string.Empty;
        public string? Requestdetails { get; set; } = string.Empty;
        public string? Intakenotes { get; set; } = string.Empty;
    }
}
