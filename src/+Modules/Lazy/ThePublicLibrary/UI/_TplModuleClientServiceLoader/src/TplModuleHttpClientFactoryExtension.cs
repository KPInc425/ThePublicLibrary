namespace TplModuleClientServiceLoader
{
    public static class TplModuleHttpClientFactoryExtension
    {
        public static void AddTplModuleHttpDataService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<ITplDataService, TplModuleHttpDataService>();
            serviceCollection.AddSingleton<ITplDataServiceNotAuthed, TplModuleHttpDataService>();
        }
    }
}