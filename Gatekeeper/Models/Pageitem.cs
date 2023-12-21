using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Pageitem
{
    public int Id { get; set; }

    public int Requestid { get; set; }

    public int Pageid { get; set; }

    public string Othertext { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }
}
