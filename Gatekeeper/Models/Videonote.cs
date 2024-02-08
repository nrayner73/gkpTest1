﻿using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;
public partial class Videonote
{
    public int Id { get; set; }

    public int Requestid { get; set; }

    public DateTime? Enterdate { get; set; }

    public int? Analystid { get; set; }

    public string? Notes { get; set; }

    public string? Timetaken { get; set; }

    public string? Status { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }
}
