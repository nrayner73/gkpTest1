using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Gatekeeper.CustomValidators;

namespace Gatekeeper.Models;

public partial class Person
{
    public int Id { get; set; }

    [PersonValidator("First Name")]
    [Required]
    public string? Firstname { get; set; }

    [PersonValidator("Last Name")]
    [Required]
    public string? Lastname { get; set; }

    public string? Middlename { get; set; }

    public string? Previousname { get; set; }

    public string? Companyname { get; set; }

    public DateTime? Birthdate { get; set; }

    [PersonValidator("Daytime phone")]
    [Required]
    public string? Daytimephone { get; set; }

    public string? Alternatephone { get; set; }

    public string? Faxphone { get; set; }

    public string? Email { get; set; }

    [PersonValidator("Street Name")]
    [Required]
    public string? Street { get; set; }

    [PersonValidator("City")]
    [Required]
    public string? City { get; set; }

    [PersonValidator("Province Name")]
    [Required]
    public string? Province { get; set; }

    public string? Postalcode { get; set; }

    public string? Country { get; set; }

    public string? Personofinterestfirstname { get; set; }

    public string? Personofinterestmiddlename { get; set; }

    public string? Personofinterestlastname { get; set; }

    public string? Remark { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createdby { get; set; }

    public string? Status { get; set; }

    public int? Gkpid { get; set; }
}
