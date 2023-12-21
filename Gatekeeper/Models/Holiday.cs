using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Holiday
{
    public int Id { get; set; }

    public string? Holidayname { get; set; }

    public DateTime? Holidaydate { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }
}
