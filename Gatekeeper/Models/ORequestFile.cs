using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class ORequestFile
{
    public short? NewFileNo { get; set; }

    public short Id { get; set; }

    public string? FileNumber { get; set; }

    public DateOnly? RequestDate { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    public DateOnly? RequestDueDate { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? Idviewed { get; set; }

    public string? RequestType { get; set; }

    public string? RecordDeliveryMethod { get; set; }

    public string? ProcessingDeficiency { get; set; }

    public string? AnalystAssigned { get; set; }

    public string? RequestDetails { get; set; }

    public string? PreviousRequests { get; set; }

    public string? IntakeNotes { get; set; }

    public string? TimeFrame { get; set; }

    public string? RequestState { get; set; }

    public string? ClosedDate { get; set; }

    public string? Archived { get; set; }

    public string? Oipccomments { get; set; }

    public DateTime Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime Createdate { get; set; }

    public string? Createuser { get; set; }
}
