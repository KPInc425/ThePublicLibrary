namespace AccountModule.ModuleClientServiceLoader
{
    public class AccountModuleHttpClientFactory
    {
        private readonly IServiceProvider _services;

        public AccountModuleHttpClientFactory(IServiceProvider services)
        {
            this._services = services;
        }

        public IAccountModuleHttpClient Create()
        {
            return new AccountModuleHttpClient(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("AccountModuleHttpClient"));
        }
        public IAccountModuleNotAuthedHttpClient CreateNotAuthed()
        {
            return new AccountModuleHttpClient(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("AccountModuleNotAuthedHttpClient"));
        }
    }
}