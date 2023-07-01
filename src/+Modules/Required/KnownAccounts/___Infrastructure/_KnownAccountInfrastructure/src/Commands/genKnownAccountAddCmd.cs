// ag=yes
namespace KnownAccountsInfrastructure.Commands; 
public partial class KnownAccountAddCmd : IRequest<KnownAccount>
{
    public string EmailAddress { get; set; }
    public string AliasName { get; set; }
    private KnownAccountAddCmd() { }
    public KnownAccountAddCmd(string aliasName, string emailAddress)
    {
        AliasName = Guard.Against.NullOrEmpty(aliasName, nameof(aliasName));
        EmailAddress = Guard.Against.NullOrEmpty(emailAddress, nameof(emailAddress));
    }
}
