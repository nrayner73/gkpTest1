using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class LkCity
{
    public int Id { get; set; }

    public string Detail { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }
}
