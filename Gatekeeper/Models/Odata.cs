using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("odata", Schema = "gkp")]
public partial class Odata
{
 public string? NewFileNo{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? FileNumber{ get; set; }
public string? RequestDate{ get; set; }
public string? ReceivedDate{ get; set; }
public string? RequestDueDate{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? ReferenceNumber{ get; set; }
public int? Idviewed{ get; set; }
public int? Requesttypeid{ get; set; }
[Column(TypeName = "varchar(150)")]
public string? RequestType{ get; set; }
public int? Recorddeliverymethodid{ get; set; }
[Column(TypeName = "varchar(150)")]
public string? RecordDeliveryMethod{ get; set; }
public int? Processingdeficiencyid{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? ProcessingDeficiency{ get; set; }
public int? Personid{ get; set; }
public int? Analystassignedid{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? AnalystAssigned{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? RequestDetails{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? PreviousRequests{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? IntakeNotes{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? TimeFrame{ get; set; }
public int? RequestStateid{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? RequestState{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? ClosedDate{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Moduser{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Createuser{ get; set; }
public string? ID{ get; set; }

}
