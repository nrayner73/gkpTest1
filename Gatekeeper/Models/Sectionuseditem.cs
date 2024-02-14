using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("sectionuseditems", Schema = "gkp")]
public partial class Sectionuseditem
{
 [Key]
public int Id{ get; set; }
public int? Requestid{ get; set; }
public int? Sectionid{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Sectiontype{ get; set; }
[Column(TypeName = "varchar(255)")]
public string? Othertext{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }

}
