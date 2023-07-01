// ag=yes
namespace KnownAccountsInfrastructure.Commands; 
public partial class KnownUserUpdateAccountCmd : IRequest<KnownUser>
{
    private KnownUserUpdateAccountCmd()
    {
    }
    public KnownUserUpdateAccountCmd(string name, string emailAddress)
    {
        Name = Guard.Against.NullOrEmpty(name);
        EmailAddress = Guard.Against.NullOrEmpty(emailAddress);
    }
    public KnownUserUpdateAccountCmd(Guid userId, string name, string emailAddress) : this(name, emailAddress)
    {
        UserId = userId;
    }
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }
}
