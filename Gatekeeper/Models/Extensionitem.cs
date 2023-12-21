using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Extensionitem
{
    public int Id { get; set; }

    public int? Requestid { get; set; }

    public int? Extensionid { get; set; }

    public string? Section { get; set; }

    public DateTime? Extensiondate { get; set; }

    public int? Dayamount { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public string? Status { get; set; }
}
