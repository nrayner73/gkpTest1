using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("videonotes", Schema = "gkp")]
public partial class Videonote
{
 [Key]
public int Id{ get; set; }
public int? Requestid{ get; set; }
public DateTime? Enterdate{ get; set; }
public int? Analystid{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? Notes{ get; set; }
[Column(TypeName = "varchar(150)")]
public string? Timetaken{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Moduser{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }

}
