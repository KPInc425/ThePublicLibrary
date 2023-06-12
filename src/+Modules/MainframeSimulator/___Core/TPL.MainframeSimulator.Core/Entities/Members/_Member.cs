namespace TPL.Core.Entities;
public class Member
{
    public Membership? Membership { get; private set; }
    public NameVO Name { get; private set; }
    public PhysicalAddressVO Address { get; set; }
    public DigitalAddressVO? Email { get; set; }
    public DigitalAddressVO? Phone { get; set; }
}
