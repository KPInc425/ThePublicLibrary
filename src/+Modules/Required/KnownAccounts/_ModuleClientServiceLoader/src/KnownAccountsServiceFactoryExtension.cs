namespace ModuleClientServiceLoader
{
    public static class KnownAccountsServiceFactoryExtension
    {
        public static void AddKnownAccountsServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IKnownAccountsService, KnownAccountsService>();   
            serviceCollection.AddSingleton<LazyKnownAccountsModuleJsInterop, LazyKnownAccountsModuleJsInterop>();            
        }
    }
}