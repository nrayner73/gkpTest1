using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Alltask
{
    public int Id { get; set; }

    public int Requestid { get; set; }

    public string? Tasktype { get; set; }

    public DateTime? Closedate { get; set; }

    public string? Taskstatus { get; set; }

    public DateTime? Modtime { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createtime { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }
}
