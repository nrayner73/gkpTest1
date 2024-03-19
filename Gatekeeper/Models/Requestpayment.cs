using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Requestpayment
{
    public int Id { get; set; }

    public int? Requestid { get; set; }

    public string? Descp { get; set; }

    public string? Paytype { get; set; }

    public DateTime? Paydate { get; set; }

    public decimal? Payamount { get; set; }

    public decimal? Finalcost { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public string? Status { get; set; }
}
