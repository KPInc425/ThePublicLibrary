namespace KnownAccountsApi.Common.Interfaces;

public interface IKnownAccountsHttpClient

{
    Task<KnownAccountViewModel> KnownAccountByNameAsync(string name);

    Task<List<KnownAccountViewModel>> KnownAccountsList();
    Task<KnownAccountViewModel> KnownAccountAddAsync(KnownAccountAddRequest request);
    Task<List<KnownAccountViewModel>> KnownAccountAllAsync();

    Task<KnownBusinessWebsiteViewModel> KnownBusinessWebsiteGet();
    Task<WebsitePageViewModel> WebsitePageGetByUrl(WebsitePageGetByUrlRequest request);
    Task<WebsitePageViewModel> WebsitePageUpdate(WebsitePageUpdateRequest request);

    Task<KnownUserViewModel> KnownUserGet();
    Task<KnownUserViewModel> KnownUserUpdateAccount(KnownUserUpdateAccountRequest request);

    Task KnownBusinessWebsiteProfileUpdateAsync(KnownBusinessWebsiteProfileUpdateRequest request);
    Task KnownBusinessWebsiteUpdateAsync(KnownBusinessWebsiteUpdateRequest request);
}

