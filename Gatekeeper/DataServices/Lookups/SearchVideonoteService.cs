using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchVideonoteService : ISearchVideonoteService
    {
        private LookupDbContext _context;
        public SearchVideonoteService(LookupDbContext context)
        {
            _context = context;
        }

    
        public List<SearchVideoNotes> GetVideotnoteList(int fileid)
        {
            SqlParameter parms = new SqlParameter { ParameterName = "@fileid", Value = fileid == 0 ? DBNull.Value : fileid };
            List<SearchVideoNotes> notes = new List<SearchVideoNotes>();
            notes = _context?.VideoNoteInfos.FromSqlRaw("Execute [gkp].[GetVideoNotes] @fileid", parms).ToList();

            return notes;
        }
    }



}
