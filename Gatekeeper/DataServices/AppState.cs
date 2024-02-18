using Gatekeeper.Models;
using Microsoft.AspNetCore.Hosting.Server;

namespace Gatekeeper.DataServices
{
    public class AppState
    {
        public string gbConnectionString { get; set; } = "Server = LAP3330\\;Database=GateKeeper;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets = true;";
        public string myMessage { get; set; }
        public Requestfile gbrequestfile { get; set; }
    }
}
