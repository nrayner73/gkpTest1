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

            XElement el = null;
          

            if (oldObj != null && newObj != null)
            {

                Type oldtype = oldObj.GetType();
                Type newtype = newObj.GetType();

                PropertyInfo[] oldprops = oldtype.GetProperties();
                PropertyInfo[] newprops = newtype.GetProperties();

              
                XElement act = null;

                if (oldprops != newObj)
                {

                    el = new XElement("root");
                    el.Add(new XElement("Activity"), type);
                    //el.Add(new XElement("Activities"));
                    // act = new XElement("Activities");
                    //act.Add(new XElement("Activity"), type);
                }

                foreach (PropertyInfo prop1 in oldprops)
                {
                    foreach (PropertyInfo prop2 in newprops)
                    {
                        if (prop1.Name == prop2.Name)
                        {
                            string value1 = "";
                            if (prop1.GetValue(oldObj) != null)
                            {
                                value1 = prop1.GetValue(oldObj).ToString();
                            }

                            string value2 = "";
                            if (prop2.GetValue(newObj) != null)
                            {
                                value2 = prop2.GetValue(newObj).ToString();
                            }
                            //if (prop1.GetValue(oldObj) != prop2.GetValue(newObj))
                            if (value1 != value2)
                            {
                                act = new XElement(prop1.Name);
                                //act.Add(new XElement("property"),prop1.Name);
                                act.Add(new XElement("old"), prop1.GetValue(oldObj));
                                act.Add(new XElement("new"), prop2.GetValue(newObj));
                                el.Add(act);
                                break;
                            }
                            

                            
                        }

                    }

                }
            }

            return el;
        }
    }
}
