namespace TPL.KnownAccounts.Core;
public class KnownAccountsCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<KnownAccount>();
        /*     .As<IToDoItemSearchService>().InstancePerLifetimeScope(); */
    }
}
