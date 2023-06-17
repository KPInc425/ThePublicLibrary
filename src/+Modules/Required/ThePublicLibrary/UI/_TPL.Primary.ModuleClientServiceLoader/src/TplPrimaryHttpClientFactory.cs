namespace TPL.Primary.ModuleClientServiceLoader
{
    public class TplPrimaryHttpClientFactory
    {
        private readonly IServiceProvider _services;

        public TplPrimaryHttpClientFactory(IServiceProvider services)
        {
            this._services = services;
        }

        public IDataService Create()
        {
            return new HttpDataService(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("TplPrimaryHttpClient"));
        }
        public IDataServiceNotAuthed CreateNotAuthed()
        {
            return new HttpDataService(this._services.GetRequiredService<IHttpClientFactory>().CreateClient("TplPrimaryNotAuthedHttpClient"));
        }
    }
}