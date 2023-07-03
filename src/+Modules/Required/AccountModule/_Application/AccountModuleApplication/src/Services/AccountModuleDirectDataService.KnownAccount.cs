namespace AccountModuleApplication.Shared.Interfaces;

public partial interface IAccountModuleDataService
{
    Task<KnownAccountViewModel> KnownAccountByNameAsync(string name);
    Task<List<KnownAccountViewModel>> AccountModuleList();
    Task<KnownAccountViewModel> KnownAccountAddAsync(KnownAccountAddRequest request);
    Task<List<KnownAccountViewModel>> KnownAccountAllAsync();
}