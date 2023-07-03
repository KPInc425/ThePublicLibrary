namespace AccountModule.ModuleClientServiceLoader
{
    public class AccountModuleServiceFactory
    {
        private readonly IServiceProvider _services;

        public AccountModuleServiceFactory(IServiceProvider services)
        {
            this._services = services;
        }

        public IAccountModuleService GetAccountModuleService()
        {
            return this._services.GetRequiredService<IAccountModuleService>();
            
        }    
    }
}