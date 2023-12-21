using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Requestfee
{
    public int Id { get; set; }

    public int? Requestid { get; set; }

    public string? Descp { get; set; }

    public string? Requesting { get; set; }

    public string? Feewaived { get; set; }

    public decimal? Finalcost { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }
}
