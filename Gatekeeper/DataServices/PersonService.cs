using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;

namespace Gatekeeper.Services
{
    public class PersonService : IPersonService
    {
        private AppDbContext _context;

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
