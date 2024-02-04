using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class LkSection
{
    public int Id { get; set; }

    public string Sectiontype { get; set; } = null!;

    public string Section { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }

    public int? Sortby { get; set; }
}
