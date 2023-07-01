// ag=yes
namespace KnownAccountsInfrastructure.Queries; 
public partial class KnownAccountGetByEmailQry : IRequest<KnownAccount>
{
    [Required]
    public string EmailAddress { get; set; }
    private KnownAccountGetByEmailQry() { }
    public KnownAccountGetByEmailQry(string emailAddress)
    {
        EmailAddress = emailAddress;
    }
}
