using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Gatekeeper.DataServices.Lookups
{
    public class SearchrequestfileService : ISearchrequestfileService
    {
        private LookupDbContext _context;
        public SearchrequestfileService(LookupDbContext context)
        {
            _context = context;
        }

        public Searchrequestfile GetRequestfileById(int fileid)
        {
            Searchrequestfile? requestfile = new Searchrequestfile();

            requestfile = _context?.RequestfileInfos.FromSqlRaw("EXECUTE [gkp].[SearchRequestFiles] @id", fileid).FirstOrDefault();

            return requestfile;
        }
        public List<Searchrequestfile> GetRequestfileList(Searchrequestfile searchfilter)
        {
            List<SqlParameter> parms = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@id",Value = searchfilter.Id ==  0 ? (object)DBNull.Value : searchfilter.Id } ,
                new SqlParameter { ParameterName = "@yearid",Value = searchfilter.Yearid == null ? (object)DBNull.Value : searchfilter.Yearid  } ,
                new SqlParameter { ParameterName = "@fileyear",Value = searchfilter.Fileyear  == null ? (object)DBNull.Value : searchfilter.Fileyear } ,
                new SqlParameter { ParameterName = "@filenumber",Value = string.IsNullOrEmpty(searchfilter.Filenumber) ? (object)DBNull.Value : searchfilter.Filenumber } ,
                new SqlParameter { ParameterName = "@requestduedatefrom",Value = searchfilter.RequestDueDateFrom == null ? (object)DBNull.Value : searchfilter.RequestDueDateFrom } ,
                new SqlParameter { ParameterName = "@requestduedateto",Value = searchfilter.RequestDueDateTo == null ? (object)DBNull.Value : searchfilter.RequestDueDateTo } ,
                new SqlParameter { ParameterName = "@referencenumber",Value = string.IsNullOrEmpty(searchfilter.Referencenumber) ? (object)DBNull.Value : searchfilter.Referencenumber } ,
                new SqlParameter { ParameterName = "@statusnote",Value = string.IsNullOrEmpty(searchfilter.Statusnote) ? (object)DBNull.Value : searchfilter.Statusnote } ,
                new SqlParameter { ParameterName = "@requesttypeid",Value = searchfilter.Requesttypeid == null ? (object)DBNull.Value : searchfilter.Requesttypeid } ,
                new SqlParameter { ParameterName = "@requesttype",Value = string.IsNullOrEmpty(searchfilter.Requesttype) ? (object)DBNull.Value : searchfilter.Requesttype} ,
                new SqlParameter { ParameterName = "@analystassigned",Value = searchfilter.Analystassigned == null ? (object)DBNull.Value : searchfilter.Analystassigned } ,
                new SqlParameter { ParameterName = "@analystassignedid",Value = searchfilter.Analystassignedid == null ? (object)DBNull.Value : searchfilter.Analystassignedid } ,
                new SqlParameter { ParameterName = "@requeststateid",Value = searchfilter.Requeststateid == null ? (object)DBNull.Value : searchfilter.Requeststateid } ,
                new SqlParameter { ParameterName = "@requeststate",Value = searchfilter.Requeststate == null ? (object)DBNull.Value : searchfilter.Requeststate } ,
                new SqlParameter { ParameterName = "@personid",Value = searchfilter.PersonId== null ? (object)DBNull.Value : searchfilter.PersonId } ,
                new SqlParameter { ParameterName = "@personname",Value = string.IsNullOrEmpty(searchfilter.Personname) ? (object)DBNull.Value : searchfilter.Personname } ,
                new SqlParameter { ParameterName = "@email",Value = string.IsNullOrEmpty(searchfilter.Email) ? (object)DBNull.Value : searchfilter.Email } ,
                new SqlParameter { ParameterName = "@daytimephone",Value = string.IsNullOrEmpty(searchfilter.Daytimephone) ? (object)DBNull.Value : searchfilter.Daytimephone } ,
                new SqlParameter { ParameterName = "@poiname",Value = string.IsNullOrEmpty(searchfilter.PersonOfInterest) ? (object)DBNull.Value : searchfilter.PersonOfInterest } ,
                new SqlParameter { ParameterName = "@requestdetails",Value = string.IsNullOrEmpty(searchfilter.Requestdetails) ? (object)DBNull.Value : searchfilter.Requestdetails } ,
                new SqlParameter { ParameterName = "@intakenotes",Value = string.IsNullOrEmpty(searchfilter.Intakenotes) ? (object)DBNull.Value : searchfilter.Intakenotes }
             };


            List<Searchrequestfile> requestfileinfo = new List<Searchrequestfile>();
            //requestfileinfo = _context?.RequestfileInfos.FromSqlRaw("EXECUTE [gkp].[SearchRequestFiles] @id,@yearid ", parms.ToArray()).ToList();

            requestfileinfo = _context?.RequestfileInfos.FromSqlRaw("EXECUTE [gkp].[SearchRequestFiles] " +
            " @id, " +
            " @yearid, " +
            " @fileyear, " +
            " @filenumber, " +
            " @requestduedatefrom, " +
            " @requestduedateto, " +
            " @referencenumber, " +
            " @statusnote, " +
            " @requesttypeid, " +
            " @requesttype, " +
            " @analystassigned, " +
            " @analystassignedid, " +
            " @requeststateid, " +
            " @requeststate, " +
            " @personid, " +
            " @personname, " +
            " @email, " +
            " @daytimephone, " +
            " @poiname, " +
            " @requestdetails, " +
            " @intakenotes ", parms.ToArray()).ToList();


            return requestfileinfo;
        }
    }
}
