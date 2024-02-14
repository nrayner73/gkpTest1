using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("analyst", Schema = "gkp")]
public partial class Analyst
{
 [Key]
public int Id{ get; set; }
[Column(TypeName = "varchar(150)")]
public string? Regno{ get; set; }
[Column(TypeName = "varchar(150)")]
public string? Localname{ get; set; }
[Column(TypeName = "varchar(150)")]
public string? Displayname{ get; set; }
[Column(TypeName = "varchar(150)")]
public string? Email{ get; set; }
[Column(TypeName = "varchar(150)")]
public string? Role{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Moduser{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }

}
