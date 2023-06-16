namespace Dpf.Infrastructure.CommandQuery;
public class DpfDirectoryAddCommand : IRequest<DpfDirectory>, IRoutable
{
    protected static string Route = "/directory/add";
    public string Name { get; }
    public string FullName { get; }
    public DpfDirectoryAddCommand(string Name, string FullName)
    {
        this.Name = Name;
        this.FullName = FullName;
    }
    public string BuildRouteFrom() {
        return DpfDirectoryAddCommand.BuildRoute();
    }
    public static string BuildRoute() { return Route; }
}
