namespace ModuleClientServiceLoader
{
    public class KnownAccountsHttpClientFactory
    {
        private readonly IServiceProvider _services;

        public KnownAccountsHttpClientFactory(IServiceProvider services)
        {
            this._services = services;
        }

        public IKnownAccountsHttpClient Create()
        {
            return new KnownAccountsHttpClient(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("KnownAccountsHttpClient"));
        }
        public IKnownAccountsNotAuthedHttpClient CreateNotAuthed()
        {
            return new KnownAccountsHttpClient(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("KnownAccountsNotAuthedHttpClient"));
        }
    }
}