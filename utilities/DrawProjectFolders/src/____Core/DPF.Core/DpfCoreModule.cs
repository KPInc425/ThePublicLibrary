using System.Reflection;
using Module = Autofac.Module;

namespace Dpf.Core;
public class DpfCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {

        foreach (var testData in Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(x => x.IsAssignableTo(typeof(ITestData)) && x.IsClass)
                    .OrderBy(rs => rs.Name))
        {
            builder.RegisterType(testData);
        }
        /* builder.RegisterType<ToDoItemSearchService>()
            .As<IToDoItemSearchService>().InstancePerLifetimeScope(); */
    }
}
