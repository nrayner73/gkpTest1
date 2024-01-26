using Gatekeeper.Models;
using Gatekeeper.Models.Lookups;
using System.Xml.Linq;


namespace Gatekeeper.Interfaces.Audit
{
    public interface IAuditlogService
    {
        Task<IEnumerable<AuditLog>> GetAuditlogList();
        Task<AuditLog> CreateAuditlog(AuditLog audit);

        XElement GetAuditxml(object oldObj,object newObj,string type);
       
    }
}
