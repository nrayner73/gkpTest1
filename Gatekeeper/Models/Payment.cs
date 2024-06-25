using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("payment", Schema = "gkp")]
public partial class Payment
{
 [Key]
public int Id{ get; set; }
public int? Requestid{ get; set; }
public int PaymentLineNumber {  get; set; }
[Column(TypeName = "varchar(250)")]
public string? Description{ get; set; }
[Column(TypeName = "varchar(250)")]
public string? Authorization{ get; set; }
public int? Paytypeid{ get; set; }
public DateTime? Paymentdate{ get; set; }
public decimal? Payamount{ get; set; }
public decimal? Finalcost{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createuser{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Moduser{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }

}
