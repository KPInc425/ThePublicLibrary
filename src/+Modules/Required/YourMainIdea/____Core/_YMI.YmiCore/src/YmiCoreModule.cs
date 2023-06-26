using System.Reflection;
using Module = Autofac.Module;

namespace YMI.YmiCore;
public class YmiCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {

        /* foreach (var ymiTestData in Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(x => x.IsAssignableTo(typeof(IYmiTestData)) && x.IsClass)
                    .OrderBy(rs => rs.Name))
        {
            builder.RegisterType(ymiTestData);
        } */        
    }
}
