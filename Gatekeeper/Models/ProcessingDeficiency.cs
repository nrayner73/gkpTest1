using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("processingDeficiency", Schema = "gkp")]
public partial class ProcessingDeficiency
{
     [Key]
    public int Id{ get; set; }
    [Column(TypeName = "varchar(150)")]
    public string? Description { get; set; }
    public DateTime? Moddate { get; set; }
    [Column(TypeName = "varchar(45)")]
    public string? SortBy { get; set; }
    public string? Moduser { get; set; }
    public DateTime? Createdate { get; set; }
    [Column(TypeName = "varchar(45)")]
    public string? Createuser { get; set; }
    [Column(TypeName = "varchar(5)")]
    public string? Status { get; set; }

}
