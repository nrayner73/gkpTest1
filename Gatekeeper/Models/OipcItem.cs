using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("oipc_items", Schema = "gkp")]
public partial class OipcItem
{
 [Key]
public int Id{ get; set; }
public int? Oipcid{ get; set; }
public int? Reasonid{ get; set; }
public int? Groupid{ get; set; }
[Column(TypeName = "varchar(250)")]
public string? Othertext{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Moduser{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }

}
