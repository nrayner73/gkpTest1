using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("requestfee", Schema = "gkp")]
public partial class Requestfee
{
 [Key]
public int Id{ get; set; }
public int? Requestid{ get; set; }
public int? Paytypeid{ get; set; }
    [Column(TypeName = "varchar(250)")]
    public string? Description { get; set; }
    public decimal? Estimatedcost{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Requested{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Feewaived{ get; set; }
public decimal? Finalcost{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Moduser{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }

}
