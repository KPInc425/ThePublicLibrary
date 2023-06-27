namespace YMI.YmiCore.Entities;
[Owned]
public class DigitalAddyVO : ValueObject
{
    public DigitalAddyType Type { get; private set; }
    public long PhoneNumber { get; private set; }
    public string Description { get; private set; }

    private DigitalAddyVO(){}
    public DigitalAddyVO(DigitalAddyType type, long phoneNumber, string description)
    {
        Type = type;
        PhoneNumber = phoneNumber;
        Description = description;
    }
}
