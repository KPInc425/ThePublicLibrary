namespace KnownAccountsApi.Common.RequestResponse;
public class KnownUserGetByEmailAddressRequest
{
    public const string Route = "/api/KnownUser";
    private KnownUserGetByEmailAddressRequest()
    { }
    public KnownUserGetByEmailAddressRequest(string emailAddress)
    {
        EmailAddress = Guard.Against.NullOrEmpty(emailAddress);
    }

    public string EmailAddress { get; set; }
    public static string BuildRoute() => Route;
}
