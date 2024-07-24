using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace Gatekeeper.Models
{
    public class AccessRequestForm
    {

        public AccessRequestForm() { }

        public AccessRequestForm(Requestfile requestFile, Person person)
        {
            //RequestFile
            Id = requestFile.Id;
            Yearid = requestFile.Yearid;
            Filenumber = requestFile.Filenumber;
            Requestdate = requestFile.Requestdate;
            Receivedate = requestFile.Receivedate;
            Requestduedate = requestFile.Requestduedate;
            Referencenumber = requestFile.Referencenumber;
            Statusnote = requestFile.Statusnote;
            Idviewed = requestFile.Idviewed;
            Requesttypeid = requestFile.Requesttypeid;
            Recorddeliverymethodid = requestFile.Recorddeliverymethodid;
            Processingdeficiency = requestFile.Processingdeficiency;
            RFPersonid = requestFile.Personid;
            Analystassignedid = requestFile.Analystassignedid;
            Requestdetails = requestFile.Requestdetails;
            Previousrequests = requestFile.Previousrequests;
            Intakenotes = requestFile.Intakenotes;
            Timeframe = requestFile.Timeframe;
            Requeststate = requestFile.Requeststate;
            Closedate = requestFile.Closedate;
            Archivedate = requestFile.Archivedate;
            Oipccomment = requestFile.Oipccomment;
            Feepayment = requestFile.Feepayment;
            Remarks = requestFile.Remarks;
            Moddate = requestFile.Moddate;
            Moduser = requestFile.Moduser;
            Createdate = requestFile.Createdate;
            Createuser = requestFile.Createuser;
            Status = requestFile.Status;
            Gkpid = requestFile.Gkpid;


            //Person
            PersonId = person.Id;
            Firstname = person.Firstname;
            Lastname = person.Lastname;
            Middlename = person.Middlename;
            Previousname = person.Previousname;
            Companyname = person.Companyname;
            Birthdate = person.Birthdate;
            Daytimephone = person.Daytimephone;
            Alternatephone = person.Alternatephone;
            Faxphone = person.Faxphone;
            Email = person.Email;
            Street = person.Street;
            City = person.City;
            Province = person.Province;
            Postalcode = person.Postalcode;
            Country = person.Country;
            Personofinterestfirstname = person.Personofinterestfirstname;
            Personofinterestlastname = person.Personofinterestlastname;
            Personofinterestmiddlename = person.Personofinterestmiddlename;
            Remark = person.Remark;




        }

        //Request File fields
        public int Id { get; set; }

        public int? Yearid { get; set; }

        public string? Filenumber { get; set; }

        [Required]
        public DateTime? Requestdate { get; set; }

        [Required]
        public DateTime? Receivedate { get; set; }

        public DateTime? Requestduedate { get; set; }

        public string? Referencenumber { get; set; }
        public string? Statusnote { get; set; }

        [Required]
        public int? Idviewed { get; set; }

        [Required]
        public int? Requesttypeid { get; set; }

        public int? Recorddeliverymethodid { get; set; }

        public int? Processingdeficiency { get; set; }

        public int? RFPersonid { get; set; }

        [Required]
        public int? Analystassignedid { get; set; }

        [Required]
        public string? Requestdetails { get; set; }

        public string? Previousrequests { get; set; }

        public string? Intakenotes { get; set; }

        public string? Timeframe { get; set; }

        public int? Requeststate { get; set; }

        public DateTime? Closedate { get; set; }

        public DateTime? Archivedate { get; set; }

        public string? Oipccomment { get; set; }

        public string? Feepayment { get; set; }

        public string? Remarks { get; set; }

        public DateTime? Moddate { get; set; }

        public string? Moduser { get; set; }

        public DateTime? Createdate { get; set; }

        public string? Createuser { get; set; }

        public string? Status { get; set; }

        public int? Gkpid { get; set; }

        //Person Fields
        public int PersonId { get; set; }
        [Required]
        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public string? Middlename { get; set; }

        public string? Previousname { get; set; }
        public string? Companyname { get; set; }
        public DateTime? Birthdate { get; set; }

        [Required]
        public string? Daytimephone { get; set; }
        public string? Alternatephone { get; set; }
        public string? Faxphone { get; set; }
        public string? Email { get; set; }

        [Required]
        public string? Street { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        public string? Province { get; set; }
        public string? Postalcode { get; set; }
        public string? Country { get; set; }
        public string? Personofinterestfirstname { get; set; }
        public string? Personofinterestmiddlename { get; set; }
        public string? Personofinterestlastname { get; set; }
        public string? Remark { get; set; }
        //public DateTime? Moddate { get; set; }
        //[Column(TypeName = "varchar(45)")]
        //public string? Moduser { get; set; }
        //public DateTime? Createdate { get; set; }
        //[Column(TypeName = "varchar(45)")]
        //public string? Createdby { get; set; }
        //[Column(TypeName = "varchar(5)")]
        //public string? Status { get; set; }
        //public int? Gkpid { get; set; }
    }
}
