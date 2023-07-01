namespace KnownAccountCore;
public class KnownAccountCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<KnownAccount>();
        /*     .As<IToDoItemSearchService>().InstancePerLifetimeScope(); */
    }
}
