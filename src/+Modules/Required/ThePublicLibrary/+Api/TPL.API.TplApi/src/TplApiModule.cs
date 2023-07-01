using System.Reflection;
using Module = Autofac.Module;

namespace TPL.API.TplApi;
public class TplApiModule : Module
{
    private readonly bool _isDevelopment = false;
    private readonly List<Assembly> _assemblies = new List<Assembly>();

    public TplApiModule(bool isDevelopment, Assembly? callingAssembly = null)
    {
        _isDevelopment = isDevelopment;
        var coreAssembly = Assembly.GetAssembly(typeof(TplCoreModule));
        var infrastructureAssembly = Assembly.GetAssembly(typeof(TplInfrastructureModule));
        var applicationAssembly = Assembly.GetAssembly(typeof(TplApplicationModule));
        //var primaryApiAssembly = Assembly.GetAssembly(typeof(TplApiModule));

        _assemblies.Add(coreAssembly!);
        _assemblies.Add(infrastructureAssembly!);
        _assemblies.Add(applicationAssembly!);
        //_assemblies.Add(primaryApiAssembly);

        if (callingAssembly != null)
        {
            _assemblies.Add(callingAssembly);
        }
    }

    protected override void Load(ContainerBuilder builder)
    {
        if (_isDevelopment)
        {
            RegisterDevelopmentOnlyDependencies(builder);
        }
        else
        {
            RegisterProductionOnlyDependencies(builder);
        }
        RegisterCommonDependencies(builder);
    }

    private void RegisterCommonDependencies(ContainerBuilder builder)
    {
        var services = new ServiceCollection();
        services.AddAutoMapper(typeof(BookMapper).GetTypeInfo().Assembly);
        builder.Populate(services);

        // register misc
        /*
        builder.RegisterType<EmailSender>().As<IEmailSender>()
            .InstancePerLifetimeScope();
        */
    }

    private void RegisterDevelopmentOnlyDependencies(ContainerBuilder builder)
    {
        // TODO: Add development only services
    }

    private void RegisterProductionOnlyDependencies(ContainerBuilder builder)
    {
        // TODO: Add production only services
    }

}
