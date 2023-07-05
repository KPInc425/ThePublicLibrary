namespace AccountModuleApplication.Shared.Interfaces;

public partial interface IAccountModuleDataService
{
    
    Task<KnownUserViewModel> KnownUserGet();
    Task<KnownUserViewModel> KnownUserUpdateAccount(KnownUserUpdateAccountRequest request);
}