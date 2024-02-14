using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("oipc", Schema = "gkp")]
public partial class Oipc
{
 [Key]
public int Id{ get; set; }
public int? Requestid{ get; set; }
public int? Reviewtypeid{ get; set; }
public DateTime? Date_received{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Oipc_file_number{ get; set; }
public DateTime? Date_to_be_completed_by{ get; set; }
public DateTime? Review_closed_date{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? What_is_being_reviewed{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Sent_to_inquiry{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? What_is_at_inquiry{ get; set; }
public DateTime? Applicant_initial_submission_date{ get; set; }
public DateTime? Respondent_initial_submission_date{ get; set; }
public DateTime? Applicant_rebuttal_submission_date{ get; set; }
public DateTime? Respondent_rebuttal_submission_date{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Order_number{ get; set; }
public DateTime? Date_order_received{ get; set; }
public DateTime? Date_of_compliance_to_order{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? Oipc_findings{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Judicial_review{ get; set; }
public DateTime? Judicial_date_review{ get; set; }
public DateTime? Submission_judicial_review_date{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Decision_number{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? Summary_of_decision{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Cpsfilenumber{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Moduser{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }

}
