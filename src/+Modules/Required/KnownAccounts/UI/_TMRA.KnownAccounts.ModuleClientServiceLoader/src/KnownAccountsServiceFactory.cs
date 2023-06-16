namespace TPL.KnownAccounts.ModuleClientServiceLoader
{
    public class KnownAccountsServiceFactory
    {
        private readonly IServiceProvider _services;

        public KnownAccountsServiceFactory(IServiceProvider services)
        {
            this._services = services;
        }

        public IKnownAccountsService GetKnownAccountsService()
        {
            return this._services.GetRequiredService<IKnownAccountsService>();
            
        }    
    }
}