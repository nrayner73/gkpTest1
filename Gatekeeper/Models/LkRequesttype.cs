using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("lk_requesttypes", Schema = "gkp")]
public partial class LkRequesttype
{
 [Key]
public int Id{ get; set; }
[Column(TypeName = "varchar(255)")]
public string? Detail{ get; set; }
[Column(TypeName = "varchar(10)")]
public string? Refertype{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }
public DateTime? Moddate { get; set; }
[Column(TypeName = "varchar(45)")]
public string? Moduser { get; set; }
public int? Sortby{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }

}
