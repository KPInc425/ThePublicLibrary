namespace TplModuleClientServiceLoader
{
    public class TplModuleHttpClientFactory
    {
        private readonly IServiceProvider _services;

        public TplModuleHttpClientFactory(IServiceProvider services)
        {
            this._services = services;
        }

        public ITplDataService Create()
        {
            return new TplModuleHttpDataService(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("TplModuleHttpClient"));
        }
        public ITplDataServiceNotAuthed CreateNotAuthed()
        {
            return new TplModuleHttpDataService(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("TplNotAuthedHttpClient"));
        }
    }
}