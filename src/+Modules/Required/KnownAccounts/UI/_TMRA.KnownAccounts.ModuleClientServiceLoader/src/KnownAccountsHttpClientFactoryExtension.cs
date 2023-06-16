namespace TPL.KnownAccounts.ModuleClientServiceLoader
{
    public static class KnownAccountsHttpClientFactoryExtension
    {
        public static void AddKnownAccountsHttpClientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IKnownAccountsHttpClient, KnownAccountsHttpClient>();
        }
    }
}