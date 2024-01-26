﻿using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models.Lookups
{
    [Keyless]
    public class SearchAnalystNotes
    {

        public int Id { get; set; }

        public int Requestid { get; set; }

        public string? Enterdate { get; set; }

        public int? Analystid { get; set; }

        public string? Analyst { get; set; }

        public string? Notes { get; set; }

        public string? Timetaken { get; set; }

        public int? Status { get; set; }

        public string? Supervisornotes { get; set; }

        public int? Supervisorapproved { get; set; }

        public DateTime? Moddate { get; set; }

        public string? Moduser { get; set; }

        public DateTime? Createdate { get; set; }

        public string? Createuser { get; set; }
    }
}
