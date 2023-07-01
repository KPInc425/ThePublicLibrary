namespace TplModuleClientServiceLoader
{
    public static class TplHttpClientFactoryExtension
    {
        public static void AddTplHttpDataService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ITplDataService, TplHttpDataService>();
            serviceCollection.AddSingleton<ITplDataServiceNotAuthed, TplHttpDataService>();
        }
    }
}