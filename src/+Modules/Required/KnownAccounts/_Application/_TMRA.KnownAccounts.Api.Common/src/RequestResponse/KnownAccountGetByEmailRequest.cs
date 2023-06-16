namespace TPL.KnownAccounts.Api.Common.RequestResponse;
public class KnownAccountGetByEmailRequest
{
    public const string Route = "/api/KnownAccount?ServerEmail={string:emailAddress}";

    [Required]
    public string EmailAddress { get; set; }

    private KnownAccountGetByEmailRequest() { }
    public KnownAccountGetByEmailRequest(string emailAddress)
    {
        EmailAddress = emailAddress;
    }

    public static string BuildRoute(string emailAddress) => Route.Replace("{string:emailAddress}", emailAddress);
}
