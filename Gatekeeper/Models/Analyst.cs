using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Analyst
{
    public int Id { get; set; }

    public string? Localname { get; set; }

    public string? Displayname { get; set; }

    public string? Email { get; set; }

    public string? Role { get; set; }

    public string? Status { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }
}
