using Gatekeeper.Interfaces.Audit;
using Gatekeeper.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Xml.Linq;

namespace Gatekeeper.DataServices.Audit
{
    public class AuditlogService : IAuditlogService
    {
        private AppDbContext _context;

        public AuditlogService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<AuditLog> CreateAuditlog(AuditLog audit)
        {
            _context.AuditLogs.Add(audit);
            await _context.SaveChangesAsync();
            return audit;
        }
      
        public async Task<IEnumerable<AuditLog>> GetAuditlogList()
        {
            return await _context.AuditLogs.ToListAsync();
        }

        public XElement GetAuditxml(object oldObj, object newObj, string type)
        {

            Type oldtype = oldObj.GetType();
            Type newtype = newObj.GetType();
            
            PropertyInfo[] oldprops = oldtype.GetProperties();
            PropertyInfo[] newprops = newtype.GetProperties();

            XElement el = null;
            XElement act = null;

            if (oldprops != newObj)
            {
                 el = new XElement("root");
                 act = new XElement("Activities");
                act.Add(new XElement("Activity"), type);
            }

            foreach (PropertyInfo prop1 in oldprops)
            {
                foreach (PropertyInfo prop2 in newprops)
                {
                    if (prop1.Name == prop2.Name)
                    {
                        if (prop1.GetValue(oldObj) != prop2.GetValue(oldObj))
                        {
                            act.Add(new XElement("property"),prop1.Name);
                            act.Add(new XElement("old"), prop1.GetValue(oldObj));
                            act.Add(new XElement("new"), prop2.GetValue(oldObj));
                        }
                    }       
                }
                el.Add(act);

                return el;


            }



            






            throw new NotImplementedException();
        }
    }
}
