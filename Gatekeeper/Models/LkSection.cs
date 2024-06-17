using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("lk_sections", Schema = "gkp")]
public partial class LkSection
{
 [Key]
public int Id{ get; set; }
[Required]
[Column(TypeName = "varchar(255)")]
public string? Sectiontype{ get; set; }
[Required]
[Column(TypeName = "varchar(255)")]
public string? Section{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }
public int? Sortby{ get; set; }

public DateTime? Moddate { get; set; }

[Column(TypeName = "varchar(45)")]
public string? Moduser { get; set; }

}
