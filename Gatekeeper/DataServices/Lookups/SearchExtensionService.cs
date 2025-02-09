﻿using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchExtensionService : ISearchExtensionService
    {
        private LookupDbContext _context;
        public SearchExtensionService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchExtension> GetExtensionList(int fileid)
        {
            SqlParameter parms = new SqlParameter { ParameterName = "@fileid", Value = fileid == 0 ? DBNull.Value : fileid };

            List<SearchExtension> items = new List<SearchExtension>();
            items =  _context?.ExtensionInfos.FromSqlRaw("Execute [gkp].[GetExtension] @fileid",parms).ToList();

            items = items.Where(c => c.Status != "del").ToList();

            return items;
        }
    }
}
