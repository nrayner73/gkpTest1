namespace Gatekeeper.Models.Lookups
{
    public class UserInfo
    {
        
        public string? gbUserReg { get; set; }
        public bool? canaccess { get; set; }

        public event Action OnChange;
        public void SetLogin(Requestfile? requestfile)
        {
            


            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}
