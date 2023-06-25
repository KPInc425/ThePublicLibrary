namespace TPL.TplCore.Entities;
[Owned]
public class DigitalAddressVO : ValueObject
{
    public DigitalAddressType Type { get; private set; }
    public long PhoneNumber { get; private set; }
    public string Description { get; private set; }

    private DigitalAddressVO(){}
    public DigitalAddressVO(DigitalAddressType type, long phoneNumber, string description)
    {
        Type = type;
        PhoneNumber = phoneNumber;
        Description = description;
    }
}
