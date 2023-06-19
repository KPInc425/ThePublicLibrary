namespace TPL.Core.Entities;
public class Member : BaseEntityTracked<Guid>, IAggregateRoot
{
    public NameVO Name { get; private set; }
    public PhysicalAddressVO Address { get; set; }
    public DigitalAddressVO? Email { get; set; }
    public DigitalAddressVO? Phone { get; set; }

    private List<MemberInMembership> _memberInMemberships = new();
    public IEnumerable<MemberInMembership> MemberInMemberships => _memberInMemberships.AsReadOnly();

}
