using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gatekeeper.CustomValidators;

namespace Gatekeeper.Models;

public partial class Requestfee
{
    public int Id { get; set; }

    public int? Requestid { get; set; }

    public string? Description { get; set; }

    public decimal? Estimatedcost { get; set; }

    public string? Requested { get; set; }

    public string? Feewaived { get; set; }

    public decimal? Finalcost { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public string? Status { get; set; }
}
