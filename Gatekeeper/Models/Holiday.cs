using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("holidays", Schema = "gkp")]
public partial class Holiday
{
 [Key]
public int Id{ get; set; }
[Required]
[Column(TypeName = "varchar(150)")]
public string? Holidayname{ get; set; }
[Required]
public DateTime? Holidaydate{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Moduser{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }

}
