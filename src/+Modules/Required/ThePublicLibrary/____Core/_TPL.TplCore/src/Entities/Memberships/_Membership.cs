namespace TPL.TplCore.Entities;
public class Membership : BaseEntityTracked<Guid>, IAggregateRoot
{
    public Guid MembershipCardNumber { get; init; }
    public string MembershipTitle { get; init; }
    public DateTime MemberSince { get; private set; }
    public DateTime IssueDate { get; private set; }
    public DateTime ExpirationDate { get; private set; }

    private List<MemberInMembership> _memberInMemberships = new();
    public IEnumerable<MemberInMembership> MemberInMemberships => _memberInMemberships.AsReadOnly();
    private Membership(){}
    
}
