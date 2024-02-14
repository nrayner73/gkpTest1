using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("AuditLog", Schema = "gkp")]
public partial class AuditLog
{
 [Key]
public int ID{ get; set; }
public DateTime? AccessDate{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? UserName{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? AccessSystem{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? Activity{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? AccessNiche{ get; set; }
public string? ActivityXml{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? OccurrenceNo{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? RegNo{ get; set; }
public DateTime? Sdate{ get; set; }

}
