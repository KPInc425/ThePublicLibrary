namespace TPL.Core.Entities;
public class MemberInMembership : BaseEntityTracked<Guid>
{
    public Member Member { get; private set; }
    public Membership Membership { get; private set; }

}
