using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Mytask
{
    public int Id { get; set; }

    public int Taskid { get; set; }

    public string? Assignby { get; set; }

    public DateTime? Assigndate { get; set; }

    public DateTime? Closedate { get; set; }

    public string? Notes { get; set; }

    public string? Mytaskstatus { get; set; }

    public string? Approveby { get; set; }

    public DateTime? Approvedate { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createtime { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }
}
