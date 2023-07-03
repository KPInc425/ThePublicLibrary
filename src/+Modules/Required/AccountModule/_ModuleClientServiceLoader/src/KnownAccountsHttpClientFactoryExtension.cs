namespace AccountModule.ModuleClientServiceLoader
{
    public static class AccountModuleHttpClientFactoryExtension
    {
        public static void AddAccountModuleHttpClientServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IAccountModuleHttpClient, AccountModuleHttpClient>();
        }
    }
}