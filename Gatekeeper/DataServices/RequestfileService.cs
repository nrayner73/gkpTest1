using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using System;
using System.Diagnostics.Eventing.Reader;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using BlazorBootstrap;
using Gatekeeper.Components.Pages.RecordDeliveryMethods;
using Gatekeeper.Components.Pages.RequestType;
using System.Net.NetworkInformation;
using System.Reflection;

namespace Gatekeeper.Services
{
    public class RequestfileService : IRequestfileService
    {
        private AppDbContext _context;

        public RequestfileService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Requestfile> GetRequestfileById(int id)
        {
            Requestfile requestfile = new Requestfile();

            if (_context.Requestfiles != null)
            {
                requestfile = await _context.Requestfiles
                .FirstOrDefaultAsync(x => x.Id == id);
            }
            return requestfile;
        }

        public async Task<Requestfile> CreateRequestfile(Requestfile requestfile)
        {
            _context.Requestfiles.Add(requestfile);
            await _context.SaveChangesAsync();
            return requestfile;
        }

        public async System.Threading.Tasks.Task UpdateRequestfile(Requestfile requestfile)
        {
            _context.Update(requestfile);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteRequestfile(Requestfile requestfile)
        {
            _context.Requestfiles.Remove(requestfile);
            await _context.SaveChangesAsync();
        }
        
    }
}

