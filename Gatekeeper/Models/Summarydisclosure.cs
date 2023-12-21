using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Summarydisclosure
{
    public int Id { get; set; }

    public int? Requestid { get; set; }

    public DateTime? Fileclosedate { get; set; }

    public string? Pagesidentified { get; set; }

    public string? Pagesdisclosed { get; set; }

    public DateTime? Pagedisclosedate { get; set; }

    public string? Videoidentified { get; set; }

    public string? Videodisclosed { get; set; }

    public DateTime? Videodisclosedate { get; set; }

    public string? Audioidentified { get; set; }

    public string? Audiodisclosed { get; set; }

    public DateTime? Audiodisclosedate { get; set; }

    public string? Remarks { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }
}
