namespace TPL.KnownAccounts.ModuleClientService
{
    public class KnownAccountsService : IKnownAccountsService
    {
        private string _activeModule;
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();

        public KnownAccountsService()
        {
            this._activeModule = "KnownAccounts";
        }
        public string ActiveModule
        {
            get => _activeModule;
        }
        public void SetActiveModule(string module) {
            _activeModule = module;
            NotifyStateChanged();
        }        
    }
}

