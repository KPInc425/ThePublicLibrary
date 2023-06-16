// ag=yes
namespace TPL.KnownAccounts.Infrastructure.Queries; 
public partial class KnownBusinessGetChildBusinessesQry : IRequest<List<KnownBusiness>>
{
    [Required]
    public Guid Id { get; set; }
    private KnownBusinessGetChildBusinessesQry() { }
    public KnownBusinessGetChildBusinessesQry(Guid id)
    {
        Id = id;
    }
}
