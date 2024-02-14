using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("mytasks", Schema = "gkp")]
public partial class Mytask
{
 [Key]
public int Id{ get; set; }
public int? Fileid{ get; set; }
public int? Taskid{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Assignby{ get; set; }
public DateTime? Assigndate{ get; set; }
public int? Taskstatusid{ get; set; }
public DateTime? Closedate{ get; set; }
[Column(TypeName = "varchar(2000)")]
public string? Notes{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Mytaskstatus{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Approveby{ get; set; }
public DateTime? Approvedate{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Moduser{ get; set; }
public DateTime? Createtime{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Createuser{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Remarks{ get; set; }

}
