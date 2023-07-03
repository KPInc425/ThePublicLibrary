namespace AccountModuleBlazorModule;
public class AccountModuleServiceWrapperService
{
    public IAccountModuleService _roomService;
    public IAccountModuleService AccountModuleService { get => _roomService; set { _roomService = value; } }
}