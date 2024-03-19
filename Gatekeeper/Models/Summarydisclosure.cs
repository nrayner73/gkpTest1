using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("summarydisclosure", Schema = "gkp")]
public partial class Summarydisclosure
{
    [Key]
    public int Id { get; set; }

    public int? Requestid { get; set; }

    public DateTime? Fileclosedate { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string? Pagesidentified { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string? Pagesdisclosed { get; set; }

    public DateTime? Pagedisclosedate { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string? Videoidentified { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string? Videodisclosed { get; set; }

    public DateTime? Videodisclosedate { get; set; }
    [Column(TypeName = "varchar(50)")]

    public string? Audioidentified { get; set; }

    [Column(TypeName = "varchar(50)")]
    public string? Audiodisclosed { get; set; }

    public DateTime? Audiodisclosedate { get; set; }

    [Column(TypeName = "varchar(max)")]
    public string? Remarks { get; set; }

    public DateTime? Moddate { get; set; }

    [Column(TypeName = "varchar(45)")]
    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    [Column(TypeName = "varchar(45)")]
    public string? Createuser { get; set; }

    [Column(TypeName = "varchar(5)")]
    public string? Status { get; set; }

}
