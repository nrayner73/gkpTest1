using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using Gatekeeper.Models;
using Gatekeeper.Interfaces;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;

namespace Gatekeeper.DataServices
{
    public class AnalystnoteService : IAnalystnoteService
    {
        private AppDbContext _context;

        public AnalystnoteService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Analystnote>> GetAnalystnoteList(int fileid)
        {

            return await _context.Analystnotes.Where(x => x.Requestid == fileid)
                    .ToListAsync();
        }

        public async Task<Analystnote> GetAnalystnoteById(int id)
        {
            return await _context.Analystnotes
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        //public List<SearchAnalystNotes> GetAnalystnoteList(int fileid)
        //{
        //    SqlParameter parms = new SqlParameter { ParameterName = "@fileid", Value = fileid == 0 ? (object)DBNull.Value : fileid };
        //    List<SearchAnalystNotes> notes = new List<SearchAnalystNotes>();
        //    notes = _context?.Analystnotes

        //    return  _context.Analystnotes
        //        .FirstOrDefaultAsync(x => x.Id == id);
        //}

        public async Task<Analystnote> CreateAnalystnote(Analystnote analystnote)
        {
            _context.Analystnotes.Add(analystnote);
            await _context.SaveChangesAsync();
            return analystnote;
        }
        public async System.Threading.Tasks.Task UpdateAnalystnote(Analystnote analystnote)
        {
            _context.Analystnotes.Update(analystnote);
            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task DeleteAnalystnote(Analystnote analystnote)
        {
            _context.Analystnotes.Remove(analystnote);
            await _context.SaveChangesAsync();
        }

    }
}
