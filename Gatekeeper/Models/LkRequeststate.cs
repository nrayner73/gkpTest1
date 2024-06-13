using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("lk_requeststate", Schema = "gkp")]
public partial class LkRequeststate
{
 [Key]
public int Id{ get; set; }
[Required]
[Column(TypeName = "varchar(255)")]
public string? Detail{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }
public int? Sortby{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }

public DateTime? Moddate { get; set; }

[Column(TypeName = "varchar(45)")]
public string? Moduser { get; set; }

}
