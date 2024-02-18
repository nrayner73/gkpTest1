

namespace Gatekeeper.Models.Lookups
{
    public class LoginState
    {
        public int? gFileId { get; set; }
        public string? gFileNumber { get; set; }
        public Requestfile Requestfile { get; set; }
        
        public event Action OnChange;
        public void SetLogin(Requestfile? requestfile)
        {
            gFileId = requestfile.Id;
            gFileNumber = requestfile.Filenumber;
            Requestfile = requestfile;


            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}
