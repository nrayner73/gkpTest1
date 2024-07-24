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

        public Requestfile CreateRequestFileFromForm(AccessRequestForm accessRequestForm)
        {
            var requestFile = new Requestfile();

            requestFile.Id = accessRequestForm.Id;
            requestFile.Yearid = accessRequestForm.Yearid;
            requestFile.Filenumber = accessRequestForm.Filenumber;
            requestFile.Requestdate = accessRequestForm.Requestdate;
            requestFile.Receivedate = accessRequestForm.Receivedate;
            requestFile.Requestduedate = accessRequestForm.Requestduedate;
            requestFile.Referencenumber = accessRequestForm.Referencenumber;
            requestFile.Statusnote = accessRequestForm.Statusnote;
            requestFile.Idviewed = accessRequestForm.Idviewed;
            requestFile.Requesttypeid = accessRequestForm.Requesttypeid;
            requestFile.Recorddeliverymethodid = accessRequestForm.Recorddeliverymethodid;
            requestFile.Processingdeficiency = accessRequestForm.Processingdeficiency;
            requestFile.Personid = accessRequestForm.RFPersonid;
            requestFile.Analystassignedid = accessRequestForm.Analystassignedid;
            requestFile.Requestdetails = accessRequestForm.Requestdetails;
            requestFile.Previousrequests = accessRequestForm.Previousrequests;
            requestFile.Intakenotes = accessRequestForm.Intakenotes;
            requestFile.Timeframe = accessRequestForm.Timeframe;
            requestFile.Requeststate = accessRequestForm.Requeststate;
            requestFile.Closedate = accessRequestForm.Closedate;
            requestFile.Archivedate = accessRequestForm.Archivedate;
            requestFile.Oipccomment = accessRequestForm.Oipccomment;
            requestFile.Feepayment = accessRequestForm.Feepayment;
            requestFile.Remarks = accessRequestForm.Remarks;
            requestFile.Moddate = accessRequestForm.Moddate;
            requestFile.Moduser = accessRequestForm.Moduser;
            requestFile.Createdate = accessRequestForm.Createdate;
            requestFile.Createuser = accessRequestForm.Createuser;
            requestFile.Status = accessRequestForm.Status;
            requestFile.Gkpid = accessRequestForm.Gkpid;


            return requestFile;
        }

        public async Task<IEnumerable<Requestfile>> GetRequestfileList(Searchrequestfile searchfilter)
        //public async Task<IEnumerable<Requestfile>> GetRequestfileList()
        {

            List<SqlParameter> parms = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@id",Value = searchfilter.Id },
                new SqlParameter { ParameterName = "@yearid",Value = searchfilter.Yearid },
                new SqlParameter { ParameterName = "@fileyear",Value = searchfilter.Fileyear },
                new SqlParameter { ParameterName = "@filenumber",Value = searchfilter.Filenumber },
                new SqlParameter { ParameterName = "@requestdate",Value = searchfilter.Requestdate },
                new SqlParameter { ParameterName = "@receivedate",Value = searchfilter.Receivedate },
                new SqlParameter { ParameterName = "@requestduedate",Value = searchfilter.Requestduedate },
                new SqlParameter { ParameterName = "@referencenumber",Value = searchfilter.Referencenumber },
                new SqlParameter { ParameterName = "@statusnote",Value = searchfilter.Statusnote },
                new SqlParameter { ParameterName = "@requesttypeid",Value = searchfilter.Requesttypeid },
                new SqlParameter { ParameterName = "@requesttype",Value = searchfilter.Requesttype },
                new SqlParameter { ParameterName = "@analystassignedid",Value = searchfilter.Analystassignedid },
                new SqlParameter { ParameterName = "@requeststateid",Value = searchfilter.Requeststateid },
                new SqlParameter { ParameterName = "@personid",Value = searchfilter.PersonId},
                new SqlParameter { ParameterName = "@firstname",Value = searchfilter.Firstname },
                new SqlParameter { ParameterName = "@lastname",Value = searchfilter.Lastname },
                new SqlParameter { ParameterName = "@middlename",Value = searchfilter.Middlename },
                new SqlParameter { ParameterName = "@poifirstname",Value = searchfilter.POIfirstname },
                new SqlParameter { ParameterName = "@poilastname",Value = searchfilter.POIlastname },
                new SqlParameter { ParameterName = "@poimiddlename",Value = searchfilter.POImiddlename },
                new SqlParameter { ParameterName = "@requestdetails",Value = searchfilter.Requestdetails },
                new SqlParameter { ParameterName = "@intakenotes",Value = searchfilter.Intakenotes }
            };

            return await _context.Requestfiles.FromSqlRaw("EXECUTE [gkp].[getRequestFile] " +
                        " @id, " +
        " @yearid, " +
        " @fileyear, " +
        " @filenumber, " +
        " @requestdate, " +
        " @requestduedate, " +
        " @receivefromdate, " +
        " @receivetodate, " +
        " @referencenumber, " +
        " @statusnote, " +
        " @requesttypeid, " +
        " @requesttype, " +
        " @analystassignedid, " +
        " @requeststateid, " +
        " @personid, " +
        " @firstname, " +
        " @lastname, " +
        " @middlename, " +
        " @poifirstname, " +
        " @poilastname, " +
        " @poimiddlename, " +
        " @requestdetails, " +
        " @intakenotes ", parms.ToArray()).ToListAsync();



                //"@id ,@yearid ,@fileyear ,@filenumber ,@requestdate ,@receivedate ,@requestduedate " +
                //",@referencenumber ,@requesttypeid ,@requesttype ,@analystassignedid ,@requeststateid " +
                //",@personid ,@firstname ,@lastname ,@middlename ,@poifirstname ,@poilastname ,@poimiddlename " +
                //",@requestdetails ,@intakenotes ", searchfilter).ToListAsync();

            //return await _context.Requestfiles
            //        .ToListAsync();
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

