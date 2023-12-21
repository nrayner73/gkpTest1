using System;
using System.Collections.Generic;

namespace Gatekeeper.Models;

public partial class Oipc
{
    public int Id { get; set; }

    public int? Requestid { get; set; }

    public int? Reviewtypeid { get; set; }

    public DateTime? DateReceived { get; set; }

    public string? OipcFileNumber { get; set; }

    public DateTime? DateToBeCompletedBy { get; set; }

    public DateTime? ReviewClosedDate { get; set; }

    public string? WhatIsBeingReviewed { get; set; }

    public string? SentToInquiry { get; set; }

    public string? WhatIsAtInquiry { get; set; }

    public DateTime? ApplicantInitialSubmissionDate { get; set; }

    public DateTime? RespondentInitialSubmissionDate { get; set; }

    public DateTime? ApplicantRebuttalSubmissionDate { get; set; }

    public DateTime? RespondentRebuttalSubmissionDate { get; set; }

    public string? OrderNumber { get; set; }

    public DateTime? DateOrderReceived { get; set; }

    public DateTime? DateOfComplianceToOrder { get; set; }

    public string? OipcFindings { get; set; }

    public string? JudicialReview { get; set; }

    public DateTime? JudicialDateReview { get; set; }

    public DateTime? SubmissionJudicialReviewDate { get; set; }

    public string? DecisionNumber { get; set; }

    public string? SummaryOfDecision { get; set; }

    public string? Cpsfilenumber { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }
}
