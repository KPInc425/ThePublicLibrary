namespace TPL.Primary.ModuleClientServiceLoader
{
    public static class TplPrimaryHttpClientFactoryExtension
    {
        public static void AddTplHttpDataService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IDataService, HttpDataService>();
            serviceCollection.AddSingleton<IDataServiceNotAuthed, HttpDataService>();
        }
    }
}