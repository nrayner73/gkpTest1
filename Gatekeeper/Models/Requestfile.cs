using Gatekeeper.CustomValidators;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Gatekeeper.Models;

public partial class Requestfile
{
    public int Id { get; set; }

    public int? Yearid { get; set; }

   

    public string? Filenumber { get; set; }

    [Required(ErrorMessage = "Request date is required")]
    public DateTime? Requestdate { get; set; }

    public DateTime? Receivedate { get; set; }

    public DateTime? Requestduedate { get; set; }

    public string? Referencenumber { get; set; }

    [Required(ErrorMessage = "ID Viewed is required")]
    public int? Idviewed { get; set; }

    [Required(ErrorMessage = "Request Type is required")]
    public int Requesttypeid { get; set; }

    public int? Recorddeliverymethodid { get; set; }

    public int? Processingdeficiency { get; set; }

  
    public int? Personid { get; set; }

    [Required(ErrorMessage = "Analyst is required")]
    public int? Analystassignedid { get; set; }

    [Required(ErrorMessage = "Request Detail is required")]
    public string? Requestdetails { get; set; }

    public string? Previousrequests { get; set; }

    public string? Intakenotes { get; set; }

    public string? Timeframe { get; set; }

    public int? Requeststate { get; set; }

    public DateTime? Closedate { get; set; }

    public DateTime? Archivedate { get; set; }

    public string? Oipccomment { get; set; }

    public string? Remarks { get; set; }

    public DateTime? Moddate { get; set; }

    public string? Moduser { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Createuser { get; set; }

    public string? Status { get; set; }

    public int? Gkpid { get; set; }

    //[Required(ErrorMessage = "Request Person is required")]
    //[ValidateObjectMembers]
    //public Person requestperson {get; set;}
}
