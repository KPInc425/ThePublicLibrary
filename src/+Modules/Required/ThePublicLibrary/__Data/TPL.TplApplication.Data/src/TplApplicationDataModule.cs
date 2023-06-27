using System.Reflection;
using Autofac;
using TPL.TplCore;
using Module = Autofac.Module;

namespace TPL.TplApplication;
public class TplApplicationDataModule : Module
{
    private readonly bool _isDevelopment = false;
    private readonly List<Assembly> _assemblies = new List<Assembly>();

    public TplApplicationDataModule(bool isDevelopment, Assembly? callingAssembly = null)
    {
        _isDevelopment = isDevelopment;
        var coreAssembly = Assembly.GetAssembly(typeof(TplCoreModule));
        var infrastructureAssembly = Assembly.GetAssembly(typeof(TplInfrastructureModule));

        _assemblies.Add(coreAssembly!);
        _assemblies.Add(infrastructureAssembly!);
        
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
        builder.RegisterGeneric(typeof(EfRepository<>))
            .As(typeof(IRepository<>))
            .As(typeof(IReadRepository<>))
            .InstancePerLifetimeScope();

        var services = new ServiceCollection();
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
