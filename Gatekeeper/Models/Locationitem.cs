using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Locationitem
{
    public int Id { get; set; }

    public int Requestid { get; set; }

    public int Locationid { get; set; }

    public string? Othertext { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }
}
