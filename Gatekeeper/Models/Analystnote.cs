using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Analystnote
{
    public int Id { get; set; }

    public int Requestid { get; set; }

    public DateTime? Enterdate { get; set; }

    public string? Analyst { get; set; }

    public string? Notes { get; set; }

    public string? Timetaken { get; set; }

    public string? Status { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }
}
