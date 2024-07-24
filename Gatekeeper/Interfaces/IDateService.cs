using Gatekeeper.Models;

namespace Gatekeeper.Interfaces
{
    public interface IDateService
    {
        //public DateTime setDuedate(Requestfile requestfile, List<Extension> extensions, List<Holiday>? holidays)
        public async System.Threading.Tasks.Task SetDuedate(Requestfile requestfile, List<Extension> extensions, List<Holiday>? holidays)
        {
        }

        public async System.Threading.Tasks.Task SetDuedate(AccessRequestForm accessRequestForm, List<Extension> extensions, List<Holiday>? holidays)
        {
        }
    }
}