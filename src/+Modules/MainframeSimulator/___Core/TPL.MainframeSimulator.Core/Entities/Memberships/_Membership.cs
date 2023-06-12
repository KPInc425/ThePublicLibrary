namespace TPL.Core.Entities;
public class Membership : BaseEntityTracked<Guid>, IAggregateRoot
{
    public Guid MembershipCardNumber { get; init; }
    public string MembershipTitle { get; init; }
    public DateTime MemberSince { get; private set; }
    public DateTime CreatedOn { get; private set; }
    public DateTime ExpiresOn { get; private set; }

    private List<Member> _members = new();
    public IEnumerable<Member> Members => _members.AsReadOnly();
    public Membership()
    {
        MembershipCardNumber = Guid.NewGuid();
        MemberSince = DateTime.UtcNow;
        CreatedOn = DateTime.UtcNow;
        ExpiresOn = DateTime.UtcNow.AddYears(1);
    }
}
