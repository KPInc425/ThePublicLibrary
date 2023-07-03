namespace AccountModule.ModuleClientService
{
    public class AccountModuleService : IAccountModuleService
    {
        private string _activeModule;
        public event Action OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();

        public AccountModuleService()
        {
            this._activeModule = "AccountModule";
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

