namespace Fernweh.BlazorClient;
public static class RegisterLazyServices
{
    public static void RegisterModules(WebAssemblyHostBuilder builder)
    {
        static void RegisterLazyServices(WebAssemblyHostBuilder builder)
        {
            RegisterLazyServicesTpl.RegisterModules(builder);
            //RegisterLazyServicesYmi();
            RegisterLazyServicesWsk.RegisterModules(builder);
        }
    }
}