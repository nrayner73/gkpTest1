using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Usernames { get; set; }

    public string? Emails { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }
}
