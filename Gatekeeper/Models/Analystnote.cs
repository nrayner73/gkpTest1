using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gatekeeper.Models;

public partial class Analystnote
{
    public int Id { get; set; }

    public int Requestid { get; set; }

    public DateTime? Enterdate { get; set; }

    public int? Analystid { get; set; }

    public string? Notes { get; set; }

    public string? Timetaken { get; set; }

    public int? Status { get; set; }

    public string? Supervisornotes { get; set; }

    public int? Supervisorapproved { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }
}
