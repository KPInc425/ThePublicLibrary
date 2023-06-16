namespace TPL.KnownAccounts.Api.Common.RequestResponse;
public class KnownAccountAddRequest
{
    public const string Route = "/api/KnownAccount";

    public string EmailAddress { get; set; }
    public string AliasName { get; set; }

    private KnownAccountAddRequest() { }
    public KnownAccountAddRequest(string aliasName, string emailAddress)
    {
        AliasName = Guard.Against.NullOrEmpty(aliasName, nameof(aliasName));
        EmailAddress = Guard.Against.NullOrEmpty(emailAddress, nameof(emailAddress));
    }
    public static string BuildRoute() => Route;
}
