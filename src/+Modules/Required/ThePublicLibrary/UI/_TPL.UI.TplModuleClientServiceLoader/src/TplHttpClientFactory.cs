namespace TPL.UI.TplModuleClientServiceLoader
{
    public class TplHttpClientFactory
    {
        private readonly IServiceProvider _services;

        public TplHttpClientFactory(IServiceProvider services)
        {
            this._services = services;
        }

        public ITplDataService Create()
        {
            return new TplHttpDataService(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("TplHttpClient"));
        }
        public ITplDataServiceNotAuthed CreateNotAuthed()
        {
            return new TplHttpDataService(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("TplNotAuthedHttpClient"));
        }
    }
}