using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("person", Schema = "gkp")]
public partial class Person
{
 [Key]
public int Id{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Firstname{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Lastname{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Middlename{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Previousname{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Companyname{ get; set; }
public DateTime? Birthdate{ get; set; }
[Column(TypeName = "varchar(500)")]
public string? Daytimephone{ get; set; }
[Column(TypeName = "varchar(500)")]
public string? Alternatephone{ get; set; }
[Column(TypeName = "varchar(500)")]
public string? Faxphone{ get; set; }
[Column(TypeName = "varchar(500)")]
public string? Email{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Street{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? City{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Province{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Postalcode{ get; set; }
[Column(TypeName = "varchar(500)")]
public string? Country{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Personofinterestfirstname{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Personofinterestmiddlename{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Personofinterestlastname{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? Remark{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Moduser{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(45)")]
public string? Createdby{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }
public int? Gkpid{ get; set; }

}
