using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using Gatekeeper.Models.Lookups;
using System.IO;

namespace Gatekeeper.Services
{
    public class PersonService : IPersonService
    {
        private AppDbContext _context;

        public Person CreatePersonFromForm(AccessRequestForm accessRequestForm)
        {
            Person person = new Person();
            person.Id = accessRequestForm.PersonId;
            person.Firstname = accessRequestForm.Firstname;
            person.Lastname = accessRequestForm.Lastname;
            person.Middlename = accessRequestForm.Middlename;
            person.Previousname = accessRequestForm.Previousname;
            person.Companyname = accessRequestForm.Companyname;
            person.Birthdate = accessRequestForm.Birthdate;
            person.Daytimephone = accessRequestForm.Daytimephone;
            person.Alternatephone = accessRequestForm.Alternatephone;
            person.Faxphone = accessRequestForm.Faxphone;
            person.Email = accessRequestForm.Email;
            person.Street = accessRequestForm.Street;
            person.City = accessRequestForm.City;
            person.Province = accessRequestForm.Province;
            person.Postalcode = accessRequestForm.Postalcode;
            person.Country = accessRequestForm.Country;
            person.Personofinterestfirstname = accessRequestForm.Personofinterestfirstname;
            person.Personofinterestlastname = accessRequestForm.Personofinterestlastname;
            person.Personofinterestmiddlename = accessRequestForm.Personofinterestmiddlename;
            person.Remark = accessRequestForm.Remark;

            return person;

        }

        public PersonService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Person>> GetPersonList()
        {
            return await _context.People
                    .ToListAsync();
        }
    
        public async Task<Person> GetPersonById(int id)
        {
            return await _context.People
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Person> CreatePerson(Person person)
        {
            _context.People.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }

        public async Task UpdatePerson(Person person)
        {
            _context.People.Update(person);
            await _context.SaveChangesAsync();
        }

        //public async System.Threading.Tasks.Task UpdatePerson(Person person)
        //{
        //    _context.People.Update(person);
        //    await _context.SaveChangesAsync();
        //}

        public async System.Threading.Tasks.Task DeletePerson(Person person)
        {
            _context.People.Remove(person);
            await _context.SaveChangesAsync();
        }

        //public async System.Threading.Tasks.Task DeletePerson(Person person)
        //{
        //    _context.People.Remove(person);
        //    await _context.SaveChangesAsync();
        //}

    }
}
