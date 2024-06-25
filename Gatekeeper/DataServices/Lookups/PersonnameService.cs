using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class PersonnameService : IPersonnameService
    {
        private LookupDbContext _context;

        public PersonnameService(LookupDbContext context)
        {
            _context = context;
        }

        public List<CompanyName> GetCompanyNames()
        {
            List<CompanyName> companyNames = new List<CompanyName>();
            companyNames = _context?.CompanyNames?.FromSqlRaw("EXECUTE [gkp].[GetCompanyName] ").ToList();

            return companyNames;
        }

        public List<PersonName>? GetNames()
        {
            List<PersonName> personNames = new List<PersonName>();
            personNames = _context?.PersonNames?.FromSqlRaw("EXECUTE [gkp].[GetPersonNames] ").ToList();

            return personNames;
        }

        public List<PersonPhone>? GetPersonPhones()
        {
            List<PersonPhone> personPhones = new List<PersonPhone>();
            personPhones = _context?.PersonPhones?.FromSqlRaw("EXECUTE [gkp].[GetPersonPhones] ").ToList();

            return personPhones;
        }

        public List<PersonEmail>? GetPersonEmails()
        {
            List<PersonEmail> personEmails = new List<PersonEmail>();
            personEmails = _context?.PersonEmails?.FromSqlRaw("EXECUTE [gkp].[GetPersonEmails] ").ToList();

            return personEmails;
        }
        public List<POIName> GetPOINames()
        {
            List<POIName> poiNames = new List<POIName>();
            poiNames = _context?.POINames?.FromSqlRaw("EXECUTE [gkp].[GetPOIname] ").ToList();

            return poiNames;
        }



    }
}
