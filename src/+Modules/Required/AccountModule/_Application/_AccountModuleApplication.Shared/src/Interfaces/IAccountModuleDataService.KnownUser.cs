namespace AccountModuleApplication.Shared.Interfaces;

public partial interface IDataServiceKnownUserPartial
{
    
    Task<KnownUserViewModel> KnownUserGet();
    Task<KnownUserViewModel> KnownUserUpdateAccount(KnownUserUpdateAccountRequest request);
}