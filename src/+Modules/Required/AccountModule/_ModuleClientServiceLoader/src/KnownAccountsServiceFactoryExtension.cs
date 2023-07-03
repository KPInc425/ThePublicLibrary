namespace AccountModule.ModuleClientServiceLoader
{
    public static class AccountModuleServiceFactoryExtension
    {
        public static void AddAccountModuleServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<IAccountModuleService, AccountModuleService>();   
            serviceCollection.AddSingleton<LazyAccountModuleJsInterop, LazyAccountModuleJsInterop>();            
        }
    }
}