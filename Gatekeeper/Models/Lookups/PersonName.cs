using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models.Lookups
{
    [Keyless]
    public class PersonName
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string middlename { get; set; }
      
        //  public string personName => this.firstname + " " + this.middlename + this.lastname;
    }

    [Keyless]
    public class CompanyName
    {
        public string companyname { get; set; }
    }


    [Keyless]
    public class PersonEmail
    {
        public string email { get; set; }
       

   
    }

    [Keyless]
    public class PersonPhone
    {
        public string daytimephone { get; set; }
       
    }


    [Keyless]
    public class POIName
    {
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }

    }
}
