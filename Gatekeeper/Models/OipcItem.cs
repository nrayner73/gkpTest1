using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class OipcItem
{
    public int Id { get; set; }

    public int? Oipcid { get; set; }

    public int? Reasonid { get; set; }

    public int? Groupid { get; set; }

    public string? Othertext { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }
}
