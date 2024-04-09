using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("extensions", Schema = "gkp")]
public partial class Extension
{
 [Key]
public int Id{ get; set; }
public int? Requestid{ get; set; }
public int? Extensionid{ get; set; }
public int? Sectionid{ get; set; }
public DateTime? Extensiondate{ get; set; }
public int? Dayamount{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Moduser{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }



}
