namespace KnownAccountsApi.Common.RequestResponse;
public class KnownUserUpdateAccountRequest
{
    public const string Route = "/api/KnownUser/UpdateAccount";

    private KnownUserUpdateAccountRequest()
    {

    }
    public KnownUserUpdateAccountRequest(string name, string emailAddress)
    {
        Name = Guard.Against.NullOrEmpty(name);
        EmailAddress = Guard.Against.NullOrEmpty(emailAddress);
    }
    public KnownUserUpdateAccountRequest(Guid userId, string name, string emailAddress) : this(name, emailAddress)
    {
        UserId = userId;
    }

    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }

    public static string BuildRoute() => Route;
}
