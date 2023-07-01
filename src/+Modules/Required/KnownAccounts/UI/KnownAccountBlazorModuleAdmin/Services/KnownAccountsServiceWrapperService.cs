namespace KnownAccountsBlazorModule;
public class KnownAccountsServiceWrapperService
{
    public IKnownAccountsService _roomService;
    public IKnownAccountsService KnownAccountsService { get => _roomService; set { _roomService = value; } }
}