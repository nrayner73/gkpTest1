using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchAnalystnoteService : ISearchAnalystnoteService
    {
        private LookupDbContext _context;
        public SearchAnalystnoteService(LookupDbContext context)
        {
            _context = context;
        }

        public List<SearchAnalystNotes> GetAnalystnoteList(int fileid)
        {
            SqlParameter parms = new SqlParameter { ParameterName = "@fileid", Value = fileid == 0 ? (object)DBNull.Value : fileid };
            List<SearchAnalystNotes> notes = new List<SearchAnalystNotes>();
            notes = _context?.AnalystNoteInfos.FromSqlRaw("Execute [gkp].[GetAnalystNotes] @fileid",parms).ToList();

            return notes;
        }
    }
}
