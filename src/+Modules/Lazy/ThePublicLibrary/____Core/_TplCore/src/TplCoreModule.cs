using System.Reflection;
using Module = Autofac.Module;

namespace TplCore;
public class TplCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {

        /* foreach (var tplTestData in Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(x => x.IsAssignableTo(typeof(ITplTestData)) && x.IsClass)
                    .OrderBy(rs => rs.Name))
        {
            builder.RegisterType(tplTestData);
        } */        
    }
}
